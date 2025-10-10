dolar = 3.78
euro = 4.20

def conv_d():
    return soles/dolar

def conv_e():
    return soles/euro

while True:
    soles 0 float(input("Ingrese el monto en soles: "))

    print("1. Convertir a dolares")
    print("2. Convertir a euros")
    print("3. Salir")

    opc = int(input("\nIngrese una opción: "))

    a = int(input("\nIngrese el primer numero: "))
    b = int(input("Ingrese el segundo numero"))

    match opc:
        case 1: suma(a,b)
        case 2: print("\n")
        case 3:
        case _: print("\nOpción no válida.")

    conti = input("\n¿Desea continuar? presione(y): ")
    if conti != "y": break
