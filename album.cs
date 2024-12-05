using System;
using System.Collections.Generic;
using System.Linq;

class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum \"{Nome}\":");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
        Console.WriteLine($"Duração total do álbum: {DuracaoTotal} segundos.");
    }
}
