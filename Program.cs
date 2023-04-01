decimal valorCompra, valorPago, valorTroco;

Console.WriteLine("--- Troco MongaShop---\n");

Console.Write("Valor da compra (R$)...: ");
valorCompra = Convert.ToDecimal(Console.ReadLine());

Console.Write("Valor pago (R$)........: ");
valorPago = Convert.ToDecimal(Console.ReadLine());

valorTroco = valorPago - valorCompra;

Console.Write ("Troco:"); Console.ForegroundColor = ConsoleColor.Green;  Console.WriteLine ($"{valorTroco:C}");
Console.ResetColor();
