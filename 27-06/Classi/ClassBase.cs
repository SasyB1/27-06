namespace _27_06.Classi
{
    public class ClassBase
    {
        // Proprietà pubblica Id di tipo intero
        public int Id { get; set; }

        // Override del metodo Equals per confrontare l'istanza corrente con un altro oggetto
        public override bool Equals(object? obj)
        {
            // Verifica se l'oggetto passato non è null 
            return obj != null &&
                // e se il tipo dell'oggetto è lo stesso della classe corrente
                obj.GetType().Equals(GetType()) &&
                // e infine se l'hash code dell'oggetto è uguale all'hash code dell'istanza corrente
                obj.GetHashCode() == GetHashCode();
        }

        // Override del metodo GetHashCode
        // Utilizza l'Id come valore hash univoco per l'istanza dell'oggetto
        public override int GetHashCode() => Id;
    }
}