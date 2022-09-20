public class AlumneMain {

	public static void main(String[] args) {
	
        <Alumne> alu = new ArrayList<Alumne>();

        Console.WriteLine("1 - Afegir un nou alumne");
        Console.WriteLine("2 - Buscar un Alumne");
        Console.WriteLine("3 - Mostrar la Llista");
        Console.WriteLine("4 - Salir");

        String input = Console.ReadLine();

        switch (input)
        {
            case "1";

                Console.WriteLine("Nom: ");
                String nom = Console.ReadLine();

                Console.WriteLine("Cognom: ");
                String Cognom = Console.ReadLine();

                Console.WriteLine("NIF: ");
                String NIF = Console.ReadLine();

                Console.WriteLine("Cicle Formatiu: ");
                String cicleFormatiu = Console.ReadLine();

                Console.WriteLine("Curs: ");
                String Curs = Console.ReadLine();

                Alumne alumne_nou = new Alumne(nom, Cognom, NIF, cicleFormatiu, Curs);

                alu.add(alumne_nou);

                break;
            case "2";
                
                Console.WriteLine("Nif del alumne que busques");
                String NIF = Console.ReadLine();

                for(Alumne x : alu){
                    if(NIF.equals(x.getNIF())){
                        x.toString();

                    }

                }


                break;

            case "3";




                break;

            
            case "4";




                break;


            default:
                break;
        }
        




}