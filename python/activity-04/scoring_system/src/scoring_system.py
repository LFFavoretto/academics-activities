class Tabela:
    def __init__(self):
        self.tabela_pontuacao = {}

    def add_jogador(self, nome, pontos):
        nome = nome.title()
        if nome not in self.tabela_pontuacao:
            self.tabela_pontuacao[nome] = pontos
            print(f"Jogador {nome} adicionado com {pontos} pontos na tabela.")
        else:
            print(f"Jogador {nome} já está na tabela, atualize os pontos.")

    def add_pontos(self, nome, pontos):
        self.tabela_pontuacao[nome] += pontos
        print(f"{pontos} pontos foram adicionados ao jogador {nome}.")

    def verificar_pontos(self, nome):
        nome = nome.title()
        if nome in self.tabela_pontuacao:
            print(f"Jogador {nome} tem {self.tabela_pontuacao[nome]} pontos.")

    def mostrar_jogadores(self):
        for jogador in self.tabela_pontuacao:
            print(f"{jogador.title()}: {self.tabela_pontuacao[jogador]} pts.")

    def maior_pontuacao(self):
        maior_ponto = 0
        maior_ponto_nome = ""
        for nome, pontos in self.tabela_pontuacao.items():
            if pontos > maior_ponto:
                maior_ponto = pontos
                maior_ponto_nome = nome
        print(f"{maior_ponto_nome}: {maior_ponto} pts")

    def tabela_ordenada(self):
        posicao = 1
        for nome in sorted(self.tabela_pontuacao, key = self.tabela_pontuacao.get, reverse=True):
            print(f"{posicao}º {nome} - {self.tabela_pontuacao[nome]} pts")
            posicao += 1

tabela1 = Tabela()
while True:
    print("""
    1 - Adicionar jogador e pontuação
    2 - Adicionar pontos a um jogador
    3 - Mostrar ponto de jogador especifico
    4 - Mostrar jogadores e pontuação
    5 - Mostrar o jogador com maior pontuação
    6 - Mostrar ranking ordenado por pontos
    7 - Sair
    """)
    try:
        opcao = int(input("Escolha uma opção: "))
    except ValueError:
        print("Digite uma opção válida!!")
        continue

    if opcao == 1:
        nome = input("Digite o nome do jogador: ")
        while True:
            try:
                pontos = int(input("Digite a quantidade de pontos: "))
                break
            except ValueError:
                print("Digite um número válido.")
        tabela1.add_jogador(nome, pontos)

    elif opcao == 2:
        nome = input("Digite o nome do jogador para adicionar pontos: ").title()
        if nome not in tabela1.tabela_pontuacao:
            print(f"{nome} não está na tabela.")
            continue
        while True:
            try:
                pontos = int(input("Digite a quantidade de pontos: "))
                break
            except ValueError:
                print("Digite um número válido.")
        tabela1.add_pontos(nome, pontos)

    elif opcao == 3:
        nome = input("Digite o nome do jogador para verificar os pontos: ")
        tabela1.verificar_pontos(nome)

    elif opcao == 4:
        tabela1.mostrar_jogadores()

    elif opcao == 5:
        tabela1.maior_pontuacao()

    elif opcao == 6:
        tabela1.tabela_ordenada()

    elif opcao == 7:
        print("Saindo...")
        break