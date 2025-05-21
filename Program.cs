using pets;

List<Pessoa> donos = new List<Pessoa>();

Pessoa p1 = new Pessoa("Daisy Kelly", 45, "Andorra");
Pessoa p2 = new Pessoa("Matilda Daniel", 34, "Botswana");

Gato g1 = new Gato("Isaac", "Persian", true, 3, p1);
Cachorro c1 = new Cachorro("Andrew", "Malinoir", false, 1, p1, PorteEnum.PEQUENO);

Cachorro c2 = new Cachorro("Tillie", "PitBull", true, 3, p2, PorteEnum.GRANDE);

p1.Pets.Add(g1);
p1.Pets.Add(c1);
p2.Pets.Add(c2);

donos.Add(p1);
donos.Add(p2);

for (int i = 0; i < donos.Count; i++)
{
    Pessoa Donos = donos[i];
    for (int j = 0; j < Donos.Pets.Count; j++)
    {
        Donos.Pets[j].Exibir();
    }
}



