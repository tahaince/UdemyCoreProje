using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez");
            RuleFor(x => x.Platform).NotEmpty().WithMessage("Platform adı boş geçilemez");
            RuleFor(x => x.Status).NotEmpty().WithMessage("Durum boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Proje değeri boş geçilemez");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Proje Url boş geçilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Proje ilerlemesi boş geçilemez");
          

        }
    }
}
