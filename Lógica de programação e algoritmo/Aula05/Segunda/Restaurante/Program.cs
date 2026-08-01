async Task Principal()
{
    Console.WriteLine("Pedido anotado");
    await Task.WhenAll(PrepararHambuguer(), PrepararBatata(),PrepararMilkShake());
    Console.WriteLine("Pedido entregue");
}
async Task PrepararHambuguer()
{
    Console.WriteLine("Preparando Hamburguer...");
    await Task.Delay(3000);
    Console.WriteLine("Hamburguer pronto!");
}
async Task PrepararBatata()
{
    Console.WriteLine("Preparando Batata Frita...");
    await Task.Delay(2500);
    Console.WriteLine("Batata Frita pronta!");
}
async Task PrepararMilkShake()
{
    Console.WriteLine("Preparando Milk Shake");
    await Task.Delay(4000);
    Console.WriteLine("Milk Shake pronto!");
}

await Principal();
