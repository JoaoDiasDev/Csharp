using HashCodeEquals1.Entities;

Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

int aHash = a.GetHashCode();
int bHash = b.GetHashCode();

Console.WriteLine(aHash.GetHashCode().Equals(bHash));
