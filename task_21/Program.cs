// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] A = Console.ReadLine().Split(',').Select(Int32.Parse).ToArray();
int[] B = Console.ReadLine().Split(',').Select(Int32.Parse).ToArray();

int x = 0;
int y = 1;
int z = 2;

double x_dist = Math.Max(A[x], B[x]) - Math.Min(A[x], B[x]);
double y_dist = Math.Max(A[y], B[y]) - Math.Min(A[y], B[y]);
double z_dist = Math.Max(A[z], B[z]) - Math.Min(A[z], B[z]);

double dist_xy = Math.Sqrt(x_dist * x_dist + y_dist * y_dist);
double dist = Math.Round(Math.Sqrt(dist_xy * dist_xy + z_dist * z_dist), 2);

Console.Write(dist);