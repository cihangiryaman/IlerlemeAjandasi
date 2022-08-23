using FluentValidation;
using IlerlemeAjandasi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.BLL.Abstract
{
    public interface IManager<T> where T : class, IEntity<T>, new()
    {
        
    }
}
