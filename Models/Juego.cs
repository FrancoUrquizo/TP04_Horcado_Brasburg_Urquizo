public static class Juego
{
    public static Dictionary<int, string> DicPalabraJuego { get; private set; }
    public static List<char> ListLetrasUsuario = new List<char>();

    public static int contadorInt { get; private set; }
    public static int ultimoId { get; private set; }
    public static List<string> posiblesPalabras = new List<string> { "auto", "vaso", "casa", "gatos", "mouse", "perro" };
    public static string palabraSeleccionada;
    public static void InicializarJuego()
    {
        Random random = new Random();
        palabraSeleccionada = posiblesPalabras[random.Next(posiblesPalabras.Count)];
        DicPalabraJuego.Add(++ultimoId, palabraSeleccionada);

    }

    public static int ContieneLetra(char LetrasUsuario)
    {
        contadorInt++;
        string comoVa = null;
        string guion = "_ ";
        int CuentasLetrasTiene = palabraSeleccionada.Count();
        int EnQPosicionEsta;




        for (int i = 0; i > CuentasLetrasTiene; i++)
        {
            comoVa += guion;

        }

        if (ListLetrasUsuario.Contains(LetrasUsuario) != true)
        {
            ListLetrasUsuario.Add(LetrasUsuario);
        }

        if (palabraSeleccionada.Contains(LetrasUsuario))
        {
            EnQPosicionEsta = Enqueposiscionesta(LetrasUsuario);
            if (EnQPosicionEsta > -1)
            {
             comoVa[EnQPosicionEsta] = LetrasUsuario;
            }

        }

        return contadorInt;

    }
    public static bool ContienePalabra(string PalabraUsario)
    {
        bool gano = false;
        if (palabraSeleccionada.Contains(PalabraUsario))
        {
            contadorInt++;
            gano = true;

        }

        return gano;

    }

    public static int Enqueposiscionesta(char LetrasUsuario)
    {
        int posicionCambiarLetra = -1;
        for (int i = 0; i > palabraSeleccionada.Count(); i++)
        {
            if (palabraSeleccionada[i] == LetrasUsuario)
            {
                posicionCambiarLetra = i;
            }

        }
        return posicionCambiarLetra;

    }





}