
package procesos;

public class VectorCaracteres
{
    private String elementos[];
    private int conta;
    
    public VectorCaracteres(int tamaño)
    {
        conta = 0;
        elementos = new String[tamaño];
    }

    public int getConta()               { return conta; }
    
    public String getElemento(int pos)  { return elementos[pos]; }
    
    public void adicionar(String dato)
    {
        elementos[conta] = dato;
        conta = conta + 1;
    }
    
    /*
    public int buscarBinaria(double dato)   // Búsqueda binaria
    {
        int limInf, limSup, medio;

        ordenar();   // Requisito

        limInf = 0;
        limSup = conta - 1;

        do
        {
            medio = (limInf + limSup) / 2;

            if (dato == elementos[medio])
                return medio;

            if (dato < elementos[medio])
                limSup = medio - 1;
            else
                limInf = medio + 1;
        }
        while(limInf <= limSup);

        return -1;
    }
     */
}
