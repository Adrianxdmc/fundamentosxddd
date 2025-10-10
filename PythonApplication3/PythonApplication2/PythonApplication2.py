def suma(a,b):
    print("\nLa suma es: ",a+b)

def resta(a,b):
    print("\nLa resta es: ",a-b)

def multi(a,b):
    print("\nLa multiplicación es: ",a*b)

def divi(a,b):
    if b !=0:
        print("\nLa division es: ",a/b)
    else: print("\nError, no se puede dividir entre 0")

while True:
    print("Bienveinidos al sistema de calculadora basica")
    print("1. Suma")
    print("2. Resta")
    print("3. Multiplicación")
    print("4. División")

    opc = int(input("\nIngrese una opción: "))

    a = int(input("\nIngrese el primer numero: "))
    b = int(input("\nIngrese ingrese el segundo numero: "))

    match opc:
        case 1: suma(a,b)
        case 2: resta(a,b)
        case 3: multi(a,b)
        case 4: divi(a,b)
        case _: print("\nOpción no valida.")

    conti = input("¿Desea continuar? presione (y): ")
    if conti != "y": break