namespace Strings.Logic
{
    public class MyString
    {
        private readonly string _text;  // _text para referenciarlo como atributo privado.  readonly significa que solo se puede asignar en el constructor y sin modificar

        public MyString(String text)   // al presionar Ctrl + .  y se asigna como un campo para generar de manera automatica private readonly string text y le agregamos el guion bajo _text
        {
            _text = text;
        }

        public bool IsPalindrome()              //método para validar si es palindroma
        {
            String aux2 = _text.ToLower();       //:ToLower convierte todo en minuscula
            aux2 = aux2.Replace('á', 'a');        //Método Replace reemplaza un valor por otro
            aux2 = aux2.Replace('é', 'e');
            aux2 = aux2.Replace('í', 'i');
            aux2 = aux2.Replace('ó', 'o');
            aux2 = aux2.Replace('ú', 'u');
            String aux = string.Empty;              //El aux va hacer un string vacio

            for (int i = 0; i<aux2.Length;i++)
            {
                if (!(aux2[i] ==' ' || aux2[i] == '.' || aux2[i] == ',' || aux2[i] == '?' || aux2[i] == '¿' || aux2[i] == '!' || aux2[i] == '¡' || aux2[i] == '"' || aux2[i] == '\''))
                {
                    aux += aux2[i];
                }
            }

            int n = aux.Length / 2;                 //Se crea una variable n para realizar la operaciòn y hacer la comparaciòn del string, int para que solo tome la parte entera


            for (int i = 0; i < n; i++) 
            {
                if (aux[i] != aux[aux.Length-i-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}