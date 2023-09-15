namespace AttributesConsoleTestProject.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class FirtsAttribute : Attribute
{
    private readonly int maxLength;

    public FirtsAttribute(int maxLength)
    {
        this.maxLength = maxLength;
    }


    public void OnEntry(string input)
    {
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input), "El valor no puede ser nulo.");
        }

        if (input.Length > maxLength)
        {
            throw new ArgumentException($"La longitud del valor debe ser menor o igual a {maxLength} caracteres.", nameof(input));
        }
    }
}