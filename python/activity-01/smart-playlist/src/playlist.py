class Musica:
    def __init__(self, musica, artista, duracao, genero):
        self.__musica = musica
        self.__artista = artista
        self.__duracao = duracao
        self.__genero = genero

    def get_musica(self):
        return self.__musica

    def set_musica(self, musica):
        self.__musica = musica

    def get_artista(self):
        return self.__artista

    def set_artista(self, artista):
        self.__artista = artista

    def get_duracao(self):
        return self.__duracao

    def set_duracao(self, duracao):
        self.__duracao = duracao

    def get_genero(self):
        return self.__genero

    def set_genero(self, genero):
        self.__genero = genero

class Playlist:
    def __init__(self):
        self.__lista_musica = []

    def add_musica(self, musica):
        self.__lista_musica.append(musica)
        return True

    def remover_musica(self, nome):
        for musica in self.__lista_musica:
            if musica.get_musica().lower() == nome.lower():
                self.__lista_musica.remove(musica)
                return True
            return False

    def listar_musicas(self):
        for item in self.__lista_musica:
            minutos = item.get_duracao() // 60
            segundos = item.get_duracao() % 60
            print(f"{item.get_musica()} - {minutos:2d}:{segundos:02d}")

    def tempo_total(self):
        tempo = 0
        for item in self.__lista_musica:
            tempo += item.get_duracao()
        minutos = tempo // 60
        segundos = tempo % 60
        print(f"Tempo total: {minutos:2d}:{segundos:02d}")

    def tempo_genero(self, genero):
        tempo_genero = 0
        for item in self.__lista_musica:
            if item.get_genero().lower() == genero.lower():
                tempo_genero += item.get_duracao()
        minutos = tempo_genero // 60
        segundos = tempo_genero % 60
        print(f"{genero.capitalize()} - {minutos:2d}:{segundos:02d}")

playlist1 = Playlist()
musica1 = Musica("Bohemian Rhapsody", "Queen", 354, "Rock")
musica2 = Musica("Back In Black", "AC/DC", 256, "Rock")
musica3 = Musica("Hey Judge", "The Beatles", 238, "Rock")
musica4 = Musica("Bad Habits", "Ed Sheeran", 230, "Pop")
musica5 = Musica("Lose Control", "Teddy Swins", 210, "Pop")
musica6 = Musica("Billie Jean", "Michael Jackson", 293, "Pop")
musica7 = Musica("Something", "Lasgo", 220, "Dance")
musica8 = Musica("Sandstorm", "Darude", 225, "Dance")
musica9 = Musica("What is Love?", "Haddaway", 270, "Dance")

playlist1.add_musica(musica1)
playlist1.add_musica(musica2)
playlist1.add_musica(musica3)
playlist1.add_musica(musica4)
playlist1.add_musica(musica5)
playlist1.add_musica(musica6)
playlist1.add_musica(musica7)
playlist1.add_musica(musica8)
playlist1.add_musica(musica9)

print()
playlist1.listar_musicas()
print()
playlist1.tempo_genero("Rock")
playlist1.tempo_genero("Pop")
playlist1.tempo_genero("Dance")
print()
playlist1.tempo_total()
print()
playlist1.remover_musica("Hey Judge")
playlist1.listar_musicas()
