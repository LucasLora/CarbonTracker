using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarbonTracker.Presenters.Common
{
    public class ModelDataValidation
    {

        #region Métodos

        public void Validate(object model)
        {
            if (model == null)
                throw new ArgumentNullException("O modelo fornecido não pode ser nulo.");
            
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, results, true);

            if (!isValid)
                throw new ValidationException(GenerateErrorMessage(results));         
        }

        private string GenerateErrorMessage(List<ValidationResult> results)
        {
            string errorMessage = "Erros de validação encontrados:";
            results.ForEach(x => errorMessage += $"\n - {x.ErrorMessage}");
            return errorMessage;
        }

        #endregion

    }
}
