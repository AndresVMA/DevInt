namespace Fundacion.Jala.DevInt.ObjectTypeApp
{
    public class CustomForm
    {
        object[] _formFields;
        int _itemIndex;
        public CustomForm(int size)
        {
            _formFields = new object[size];
        }

        public void AddValue(object value)
        {
            _formFields[_itemIndex++] = value;
        }

        public object GetValue(int index)
        {
            if (index < _formFields.Length)
            {
                return _formFields[index];
            }
            return null;
        }
    }
}
