using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyApi1.Models;

namespace MyApi1.MediatRModel
{
    public class GetBoxRequest : IRequest<GetBoxResponse>
    {
        public string BoxNo { get; set; } = string.Empty;
    }

    public class GetBoxResponse
    {
        public string BoxNo { get; set; } = string.Empty;
        public string BoxStatus { get; set; } = string.Empty;
        public int Qty { get; set; }
        public int PackQty { get; set; }
    }

    public class AddBoxRequest : IRequest<string>
    {
        public string BoxNo { get; set; } = string.Empty;
        public string ModelCode { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int Qty { get; set; }
        public int PackQty { get; set; }
        public string LineCode { get; set; } = string.Empty;
    }

    public class RemoveBoxRequest : IRequest<string>
    {
        public string BoxNo { get; set; } = string.Empty;
    }

    public class GetBoxHandler : IRequestHandler<GetBoxRequest, GetBoxResponse>
    {
        private readonly Mes3Context _context;

        public GetBoxHandler(Mes3Context context)
        {
            _context = context;
        }

        public async Task<GetBoxResponse> Handle(
            GetBoxRequest request,
            CancellationToken cancellationToken
        )
        {
            var box = await _context.Boxes.SingleOrDefaultAsync(p => p.Boxno == request.BoxNo);
            if (box == null)
            {
                throw new Exception($"Can not find box no: [{request.BoxNo}]");
            }

            return new GetBoxResponse
            {
                BoxNo = box.Boxno,
                BoxStatus = box.Status,
                Qty = box.Qty,
                PackQty = box.Packqty
            };
        }
    }

    public class AddBoxCommandHandler : IRequestHandler<AddBoxRequest, string>
    {
        private readonly Mes3Context _context;

        public AddBoxCommandHandler(Mes3Context context)
        {
            _context = context;
        }

        public async Task<string> Handle(AddBoxRequest request, CancellationToken cancellationToken)
        {
            var box = new Box 
            { 
                Boxno = request.BoxNo,
                Modelcode = request.ModelCode,
                Status = request.Status,
                Qty = request.Qty,
                Packqty = request.PackQty,
                Linecode = request.LineCode,
                Cdt = DateTime.Now,
                Udt = DateTime.Now,
                Inspecting = false
            };

            await _context.AddAsync(box, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return request.BoxNo;
        }
    }

    public class RemoveCommandHandler : IRequestHandler<RemoveBoxRequest, string>
    {
        private readonly Mes3Context _context;

        public RemoveCommandHandler(Mes3Context context)
        {
            _context = context;
        }

        public async Task<string> Handle(
            RemoveBoxRequest request,
            CancellationToken cancellationToken
        )
        {
            var box = await _context.Boxes.SingleOrDefaultAsync(p => p.Boxno == request.BoxNo);
            if (box == null)
            {
                throw new Exception($"Can not find box no: [{request.BoxNo}]");
            }

            _context.Remove(box);
            await _context.SaveChangesAsync();

            return box.Boxno;
        }
    }
}
