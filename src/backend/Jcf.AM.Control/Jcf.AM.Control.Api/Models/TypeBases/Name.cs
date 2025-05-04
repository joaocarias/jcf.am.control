namespace Jcf.AM.Control.Api.Models.TypeBases
{
    public class Name : ITypeBases
    {
        private int _minLength = 3;
        private int _maxLength = 256;

        public Name(string value)
        {
            if (!IsValid(value))
                throw new ArgumentException($"{nameof(Name)} Não é Válido");

            Value = value;
        }  
        
        public string Value { get; private set; }

        public bool IsValid(object value)
        {
            if (((string) value).Length < _minLength)            
                throw new AggregateException($"{nameof(Name)} Não é Válido: Mínimo de {_minLength} Caracteres");

            if (((string)value).Length > _maxLength)
                throw new AggregateException($"{nameof(Name)} Não é Válido:Máximo de {_maxLength} Caracteres");

            return true;            
        }
    }
}
