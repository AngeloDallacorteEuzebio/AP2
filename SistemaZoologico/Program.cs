using SistemaZoologico;

public class Program
{
    public static List<Animal> animais = new List<Animal>();
    public static List<Funcionario> funcionarios = new List<Funcionario>();

    static void Main(string[] args)
    {
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("1. Cadastrar Animal");
            Console.WriteLine("2. Cadastrar Funcionário");
            Console.WriteLine("3. Interação Animal-Funcionário");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": CadastrarAnimal(); 
                    break;
                case "2": CadastrarFuncionario(); 
                    break;
                case "3": Interagir(); 
                    break;
                case "4": executando = false; 
                    break;
                default: Console.WriteLine("Opção inválida."); 
                    break;
            }
        }
    }

    static void CadastrarAnimal()
    {
        Console.Write("Digite o tipo de animal (Mamífero, Ave, Réptil): ");
        string tipo = Console.ReadLine();

        Console.Write("Nome: "); string nome = Console.ReadLine();
        Console.Write("Idade: "); int idade = int.Parse(Console.ReadLine());
        Console.Write("Peso: "); double peso = double.Parse(Console.ReadLine());
        Console.Write("Espécie: "); string especie = Console.ReadLine();

        Animal animal = null;

        if (tipo == "Mamífero")
        {
            animal = new Mamifero(nome, idade, peso, especie);
        }
        else if (tipo == "Ave")
        {
            animal = new Ave(nome, idade, peso, especie);
        }
        else if (tipo == "Réptil")
        {
            animal = new Reptil(nome, idade, peso, especie);
        }

        if (animal != null)
        {
            animais.Add(animal);
            Console.WriteLine($"Animal cadastrado com sucesso: Nome: {animal.Nome}, Idade: {animal.Idade}, Peso: {animal.Peso}kg, Espécie: {animal.Especie}.");
        }
        else
        {
            Console.WriteLine("Tipo de animal inválido.");
        }
    }

    static void CadastrarFuncionario()
    {
        Console.Write("Digite o tipo de funcionário (Veterinário, Zelador): ");
        string tipo = Console.ReadLine();

        Console.Write("Nome: "); string nome = Console.ReadLine();
        Console.Write("Idade: "); int idade = int.Parse(Console.ReadLine());

        Funcionario funcionario = null;

        if (tipo == "Veterinário")
        {
            funcionario = new Veterinario(nome, idade);
        }
        else if (tipo == "Zelador")
        {
            funcionario = new Zelador(nome, idade);
        }

        if (funcionario != null)
        {
            funcionarios.Add(funcionario);
            Console.WriteLine($"Funcionário cadastrado com sucesso: Nome: {funcionario.Nome}, Idade: {funcionario.Idade}, Cargo: {funcionario.Cargo}.");
        }
        else
        {
            Console.WriteLine("Tipo de funcionário inválido.");
        }
    }

    static void Interagir()
    {
        if (animais.Count == 0 || funcionarios.Count == 0)
        {
            Console.WriteLine("É necessário ter ao menos um animal e um funcionário cadastrados.");
            return;
        }

        Console.WriteLine("\nAnimais cadastrados:");
        for (int i = 0; i < animais.Count; i++)
            Console.WriteLine($"{i}: {animais[i].Nome} - {animais[i].Especie}");

        Console.Write("Escolha o número do animal: ");
        int idxAnimal = int.Parse(Console.ReadLine());
        Animal animalSelecionado = animais[idxAnimal];

        Console.WriteLine("\nFuncionários cadastrados:");
        for (int i = 0; i < funcionarios.Count; i++)
            Console.WriteLine($"{i}: {funcionarios[i].Nome} - {funcionarios[i].Cargo}");

        Console.Write("Escolha o número do funcionário: ");
        int idxFuncionario = int.Parse(Console.ReadLine());
        Funcionario funcionarioSelecionado = funcionarios[idxFuncionario];

        if (funcionarioSelecionado is Veterinario vet)
        {
            vet.ConsultarAnimal(animalSelecionado);
            vet.RealizarTratamento(animalSelecionado);
        }
        else if (funcionarioSelecionado is Zelador zelador)
        {
            zelador.AlimentarAnimal(animalSelecionado);
            zelador.CuidarHabitat(animalSelecionado);
        }
    }
}