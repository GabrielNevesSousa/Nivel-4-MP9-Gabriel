public class StringBasic{

    private String Cadena;
    

    public StringBasic(String Cadena){
        this.Cadena = Cadena;

    }

    public String getCadena() {
		return Cadena;
	}

    public void setCadena(String Cadena){
        this.Cadena = Cadena;

    }

    public int NumeroVocales(String Cadena){

        int contador = 0;

    foreach (char letra in Cadena.ToLower()){
        if((letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u')){
            contador++;
        }
    }

    return contador++;
        
    }

    public int NumeroConsonantes(String Cadena){

        int contador = 0;

      foreach (char letra in Cadena.ToLower()){
        if((letra == 'b') || (letra == 'c') || (letra == 'd') || (letra == 'f') || (letra == 'g') || (letra == 'h') || (letra == 'j') || (letra == 'k')
        || (letra == 'l') || (letra == 'm') || (letra == 'n') || (letra == 'p') || (letra == 'q') || (letra == 'r') || (letra == 's') || (letra == 't') || (letra == 'v')
        || (letra == 'x') || (letra == 'w') || (letra == 'y') || (letra == 'z')){
            contador++;
        }
    }

    return contador++;  

    }

    public int NumeroPalabras(String Cadena){

        int contador = 0;

    foreach (char letra in Cadena.ToLower()){
        if(((letra == ' '){
            contador++;
        }
    }

    return contador +1;


    }

    public int NumeroCaracteresEspeciales(String Cadena){

        int contador = 0;

    foreach (char caracteres in Cadena){
        if ((caracteres == '(') || (caracteres == ')') || (caracteres == '()') || (caracteres == '*') || (caracteres == '+') || (caracteres == '-') || (caracteres == '/')){
            contador++;
        }
        
    }

    return contador++

    }

    public int NumeroCaracterRepetido(String Cadena){

    }

    public String InvertirCaracteres(String Cadena){
        String invertir="";

        for (int x = Cadena.length() - 1; x >= 0; x--){
            invertir = invertir + Cadena.charAt[x];
        }

        return invertir;

    }

    public String Sustituicion(String Cadena){

        String sustituto = "*";

        for (int i = 0; i < Cadena.length; i++){
            sustituto = sustituto.Replace(Cadena[i]);
            
        }
        


    }
}