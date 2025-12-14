using System;

public class Program
{
    public static void Main()
    {
        double X = 580; 
        double Y = 34; 
        double step = 1.0; 
        double step_k = 0.35; 

        Console.Write("Введіть довжину будинку (L) в метрах: ");
        double L = Convert.ToDouble(Console.ReadLine());

        double X_m = X / 100.0;
        double half_X = X_m / 2.0;
        double Y_rad = Math.PI * Y / 180.0;
        double stropil_length = half_X / Math.Cos(Y_rad);
        double num_stropil_one_side = Math.Ceiling(L / step) + 1;
        double total_stropil = num_stropil_one_side * 2;

        Console.WriteLine("1. стропила:");
        Console.WriteLine($"Довжина одного стропила: {stropil_length:F2} м");
        Console.WriteLine($"Загальна кількість стропил: {total_stropil} шт.\n");

        double zatyazhka_length = X_m;
        double num_zatyazhka = num_stropil_one_side;

        Console.WriteLine("2. затяжки:");
        Console.WriteLine($"Довжина однієї затяжки: {zatyazhka_length:F2} м");
        Console.WriteLine($"Кількість затяжок: {num_zatyazhka} шт.\n");

        double num_rows_obreshitka = Math.Ceiling(stropil_length / step_k) + 1;
        double obreshitka_board_length = L;
        double total_obreshitka_boards = num_rows_obreshitka * 2;

        Console.WriteLine("3. обрешітка:");
        Console.WriteLine($"Довжина однієї дошки: {obreshitka_board_length:F2} м");
        Console.WriteLine($"Загальна кількість дощок: {total_obreshitka_boards} шт.\n");

        double shifer_width = 1.125;
        double shifer_height = 1.75;
        double overlap_horiz = 0.125;
        double overlap_vert = 0.25;


        double useful_width = shifer_width - overlap_horiz;
        double useful_height = shifer_height - overlap_vert;
        double num_shifer_horiz = Math.Ceiling(L / useful_width);
        double num_shifer_vert = Math.Ceiling(stropil_length / useful_height);
        double total_shifer = num_shifer_horiz * num_shifer_vert * 2;

        Console.WriteLine("4. шифер:");
        Console.WriteLine($"Корисна ширина листа: {useful_width:F2} м");
        Console.WriteLine($"Корисна висота листа: {useful_height:F2} м");
        Console.WriteLine($"Загальна кількість шиферин: {total_shifer} шт.");
    }
}
