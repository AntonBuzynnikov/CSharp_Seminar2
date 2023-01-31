//                                         r1        r2
//23. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y 
//!(X || Y)==!X && !Y
bool x = false;
bool y = false;
System.Console.Write("Выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y: ");
System.Console.Write(!(x || y)==!x && !y);