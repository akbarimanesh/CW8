using cw8.Entitys;
using cw8.Enums;
using cw8.Services;
Product product = new Product();
ProductService productService = new ProductService();
int option;

do
{

    Console.Clear();
    Console.WriteLine("1:Add product ");
    Console.WriteLine("2:View all Products ");
    Console.WriteLine("3:Remove the product ");
    Console.WriteLine("4:View Product ");
    Console.WriteLine("5:Update Product");
    Console.WriteLine("6:Exit ");
    Console.Write("please Enter your option : ");

    option = int.Parse(Console.ReadLine());


    switch (option)
    {
        case 1:
            AddProduct();
            break;
        case 2:
            ViewallProducts();
            break;
        case 3:
            RemoveProduct();
            break;
        case 4:
            ViewProduct();
            break;
        case 5:
            UpdateProduct();
            break;

        default:
            break;
    }






} while (option < 6);




void AddProduct()
{
    Console.Clear();

    var id = productService.index();
    product.Id = id + 1;

    Console.Write("Enter name product : ");
    product.NameProduct = Console.ReadLine();

    Console.Write("Enter category product : mobile=1  tv=2  refrigerator=3  laundry=4  dishwasher=5 :");
    product.category = (EnumCategory)Enum.Parse(typeof(EnumCategory), Console.ReadLine());

    Console.Write("Enter price product :");
    product.Price = int.Parse(Console.ReadLine());

    productService.AddProduct(product);

    Console.WriteLine("Product added successfully.");

    Console.ReadKey();

}
void ViewallProducts()
{
    Console.Clear();
    var products = productService.GetAll();
    foreach (var product in products)
    {
        Console.WriteLine($"{product.Id}= Name: {product.NameProduct} Price: {product.Price} Category: {product.category}");
        Console.WriteLine("**************************************************************************");
    }



    Console.ReadKey();

}
void RemoveProduct()
{

    Console.Clear();

    var products = productService.GetAll();
    foreach (var product in products)
    {
        Console.WriteLine($"{product.Id}= Name: {product.NameProduct} Price: {product.Price} Category: {product.category}");
      
    }

    Console.WriteLine("*******************************************");
    try
    {
        Console.Write("Enter id product :");
        product.Id = int.Parse(Console.ReadLine());
        productService.Remove(product);
        Console.WriteLine("Product removed successfully.");
    }

    catch (FormatException ex)
    {
        Console.WriteLine("Please Enter A Number.");
    }


    Console.ReadKey();
}
void ViewProduct()
{
    Console.Clear();
    try
    {
        Console.Write("Enter id product :");
        product.Id = int.Parse(Console.ReadLine());
        var pro = productService.Get(product);
        Console.WriteLine($"{pro.Id}= Name: {pro.NameProduct} Price: {pro.Price} Category: {pro.category}");
        Console.WriteLine("**************************************************************************");
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Please Enter A Number.");
    }

    Console.ReadKey();

}
void UpdateProduct()
{
    Console.Clear();
    try
    {
        Console.Write("Enter id product :");
        product.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter name product : ");
        product.NameProduct = Console.ReadLine();

        Console.Write("Enter category product : mobile=1  tv=2  refrigerator=3  laundry=4  dishwasher=5 :");
        product.category = (EnumCategory)Enum.Parse(typeof(EnumCategory), Console.ReadLine());

        Console.Write("Enter price product :");
        product.Price = int.Parse(Console.ReadLine());

        productService.Update(product);


        Console.WriteLine("Product updated successfully.");
    }

    catch (FormatException ex)
    {
        Console.WriteLine("Please Enter A Number.");
    }

    Console.ReadKey();

}