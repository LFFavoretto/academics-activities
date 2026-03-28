class Inventario:
    def __init__(self):
        self.inv_assombrado = {}
        self.comodo_perigo = {}

    def add_objeto(self, objeto, local, nivel):
        self.comodo_perigo = {}
        self.comodo_perigo["comodo"] = local
        self.comodo_perigo["perigo"] = nivel
        self.inv_assombrado[objeto] = self.comodo_perigo

    def mostrar_lista(self):
        for objeto, dados in self.inv_assombrado.items():
            print(f"{objeto} - Objeto encontrado no(a): {dados["comodo"]} - Perigo: {dados["perigo"]}")

    def contar_perigos(self):
        contar = 0
        for objeto, dados in self.inv_assombrado.items():
            if dados["perigo"] == "Alto":
                contar += 1
        print(f"Total de objetos perigosos: {contar}")

    def tamanho_dicionario(self):
        return len(self.inv_assombrado) < 3

inventario1 = Inventario()
while inventario1.tamanho_dicionario():
        objeto = input("Nome do objeto encontrado: ").capitalize()
        local = input("Local onde o objeto foi encontrado: ").capitalize()
        nivel = input("Nivel de perigo do local: ").capitalize()
        inventario1.add_objeto(objeto, local, nivel)
print()
print("Objetos encontrados na casa:\n")
inventario1.mostrar_lista()
print()
inventario1.contar_perigos()