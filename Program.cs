using System.Globalization;
using SistemaHotel.Model;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

Pessoa pessoa1 = new Pessoa("Leonardo", "Henrique");
Pessoa pessoa2 = new Pessoa("Leo", "Henrique");
Pessoa pessoa3 = new Pessoa("Leonardo", "Lima");

List<Pessoa> hospedes = new List<Pessoa>();
hospedes.Add(pessoa1);
hospedes.Add(pessoa2);
hospedes.Add(pessoa3);

Suite suite1 = new Suite("Master", 3, 200M);
Reserva reserva1 = new Reserva(suite1, 11);

reserva1.CadastrarHospedes(hospedes);

Console.WriteLine($"Tipo de suite: {suite1.TipoSuite}\nQuatidade de hospedes: {reserva1.ObterQuantidadeHospede()}\nValor Diária x Dias: {reserva1.CalcularValorDiaria():C}");
    
