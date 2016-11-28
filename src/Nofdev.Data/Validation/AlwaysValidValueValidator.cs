using System;

namespace Nofdev.Data.Validation
{
    [Validator("NULL")]
    [Serializable]
    public class AlwaysValidValueValidator : ValueValidatorBase
    {
        public override bool IsValid(object value)
        {
            return true;
        }
    }
}