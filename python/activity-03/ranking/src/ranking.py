class Ranking:
    def __init__(self):
        self.ranking = []

    def add_ultimo(self, nome):
        if self.verificar_tamanho():
            self.ranking.append(nome.capitalize())
            self.lista_atualizada()

    def add_posicao(self, nome, i):
        if self.verificar_tamanho():
            self.ranking.insert(i - 1, nome.capitalize())
            self.lista_atualizada()

    def remover_posicao(self, posicao):
        i = posicao - 1
        self.ranking.pop(i)
        self.lista_atualizada()

    def contar_nomes(self, nome):
        print(f"{nome.capitalize()}: Aparece {self.ranking.count(nome.capitalize())} vezes no ranking")


    def ordenar(self):
        self.ranking.sort()
        for posicao in range(len(self.ranking)):
            print(f"{posicao + 1} - {self.ranking[posicao]}")

    def verificar_tamanho(self):
        if len(self.ranking) < 10:
            return True
        else:
            print("Ranking atingiu o limite máximo de jogadores")

    def lista_atualizada(self):
        for i in range(len(self.ranking)):
            print(f"{i + 1} - {self.ranking[i]}")

ranking1 = Ranking()
while True:
    print("""
    1 - Adicionar na última posição do ranking
    2 - Adicionar em posição específica
    3 - Remover por posição
    4 - Contar nomes repetidos no ranking
    5 - Exibir o ranking
    6 - Sair do programa
    """)
    try:
        opcao = int(input("Digite a opção: "))

    except ValueError:
        print("Digite um número inteiro")
        continue

    if opcao < 1 or opcao > 6:
        print("Digite uma opção válida.")

    elif opcao == 1:
        nome = input("Digite o nome do jogador: \n").capitalize()
        ranking1.add_ultimo(nome)

    elif opcao == 2:
        nome = input("Digite o nome do jogador: \n").capitalize()
        while True:
            try:
                posicao = int(input("Digite a posição: \n"))
                break
            except ValueError:
                print("Digite um número inteiro")
        ranking1.add_posicao(nome,posicao)

    elif opcao == 3:
        while True:
            try:
                posicao = int(input("Digite a posição do jogador que deseja remover: \n"))
                break
            except ValueError:
                print("Digite um número inteiro")
        ranking1.remover_posicao(posicao)

    elif opcao == 4:
        nome = input("Digite o nome que deseja contar: ").capitalize()
        ranking1.contar_nomes(nome)

    elif opcao == 5:
        ranking1.ordenar()

    elif opcao == 6:
        print("Saindo...")
        break