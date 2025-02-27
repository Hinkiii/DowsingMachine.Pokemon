﻿namespace PBT.DowsingMachine.Pokemon.Common;

public interface IPokemonProject
{
    public GameInfo Game { get; set; }

    public void Set(GameTitle title)
    {
        Game = GameInfo.GameList.First(x => x.Title == title);
    }
}
