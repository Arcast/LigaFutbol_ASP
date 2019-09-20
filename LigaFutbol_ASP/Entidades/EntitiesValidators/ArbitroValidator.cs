using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class ArbitroValidator : AbstractValidator<Arbitro>
    {
        public ArbitroValidator()
        {
            RuleFor(a => a.Nombres).NotNull().MaximumLength(100).WithMessage("Los nombres del árbrito son requeridos.");
            RuleFor(a => a.Apellidos).NotNull().MaximumLength(100).WithMessage("Los apellios del árbrito son requeridos.");
            RuleFor(a => a.Cedula).NotNull().MaximumLength(20).WithMessage("El número de cédula es requerido.");
            RuleFor(a => a.Telefono).NotNull();
            RuleFor(a => a.Direccion).NotNull().MaximumLength(250);
        }
    }
}
