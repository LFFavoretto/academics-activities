quantidade = int(input("Quantidade de números a ser digitado: "))
lista_numeros = []
n = 0
while n < quantidade:
    numero = int(input("Digite um numero inteiro: "))
    lista_numeros.append(numero)
    n += 1

n = 0
maior = 0
soma = 0
maior_atual = 0
soma_atual = 0
while n < len(lista_numeros):
    if lista_numeros[n] > 0:
        soma_atual += lista_numeros[n]
        maior_atual += 1

        if maior_atual > maior:
            maior = maior_atual
            soma = soma_atual
    else:
        soma_atual = 0
        maior_atual = 0
    n += 1
print(f"Maior Sequencia: {maior}")
print(f"Soma da Sequência: {soma}")