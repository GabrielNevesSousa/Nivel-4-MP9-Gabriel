public class Alumne{

    private String Nom;
    private String Cognom;
    private String NIF;
    private String Cicle_Formatiu;
    private int Curs;

    public Alumne(String nom, String Cognom, String NIF, String Cicle_Formatiu, int Curs){
        this.nom = nom;
        this.Cognom = Cognom;
        this.NIF = NIF;
        this.Cicle_Formatiu = Cicle_Formatiu;
        this.Curs = Curs;
    }

    public String getNom() {
		return nom;
	}

    public String getCognom(){
        return Cognom;
    }

    public String getNIF(){
        return NIF;
    }

    public String getCicle_Formatiu(){
        return Cicle_Formatiu;
    }

    public int getCurs(){
        return Curs;
    }

    public void setNom(String nom) {
		this.nom = nom;
	}
	
	public void setCognom(String Cognom) {
		this.Cognom = Cognom;
	}
	
	public void setNIF(String nif) {
		this.NIF = nif;
	}
	
	public void setCicleFormatiu(String cicleFormatiu) {
		this.cicleFormatiu = cicleFormatiu;
	}
	
	public void setCurs(int curs) {
		this.Curs = curs;
	}
    
    public String toString(){
        return this.nom, this.Cognom, this.NIF, this.Cicle_Formatiu, this.Curs
    }

    public boolean equals(Alum){
        if(this.nom.equals(Alum.getNom())&& this.Cognom.equals(Alum.getCognom())&& this.NIF.equals(Alum.getNIF)){
            return true;
        }else{
            return false;
        }

    }
}