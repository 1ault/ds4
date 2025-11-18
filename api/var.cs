// Declare
int var_int = 0;
const int const_var_int = 0;

// Char
char character = 'A';
string characters = "ABC";

// Numbers
sbyte sbyte_min = -128;
sbyte sbyte_max = 127;

byte byte_min = 0;
byte byte_max = 255;

ushort ushort_min = 0;
ushort ushort_max = 65_535;

short short_min = -32_768;
short short_max = 32_767;

int int_min = -2_147_483_648;
int int_max = 2_147_483_647;

uint uint_min = 0;
uint uint_max = 4_294_967_295;

long long_min = -9_223_372_036_854_755_808;
long long_max = 9_223_372_036_854_755_807;

ulong ulong_min = 0;
ulong ulong_max = 18_446_744_073_709_551_615;

float float_min = 0;
float float_max = 0;

double double_min = 0;
double double_max = 0;


foreach (int i in Enumerable.Range(0, 100)) { }

// Array
string[] arrays_string = new sring[5];
string arrays_string_2 = { "one", "two", "tree" };

int[] arrays_int = new int[5];

arrays_int[0] = 10;
arrays_int[1] = 20;
arrays_int[4] = 50;
int a = arrays_int[0]; // 10
int b = arrays_int[1]; // 20
int c = arrays_int[4]; // 50

// Random
Random random = new Random();
// 0 - 9
random.Next(10);

// 1 - 10
random.Next(1, 11);
random.NextDouble();
