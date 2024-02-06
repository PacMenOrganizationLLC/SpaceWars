﻿using SpaceWars.Logic;

namespace SpaceWars.Web.Types;

public record JoinGameResponse(
    string Token,
    Location StartingLocation,
    string GameState,
    int Heading,
    int BoardWidth,
    int BoardHeight,
    IEnumerable<PurchasableItem> Shop
);
public record Location(int X, int Y);
public record GameStateResponse(string GameState, IEnumerable<Location> PlayerLocations);
public record PlayerMessageResponse(string Type, string Message);
public record QueueActionRequest(string Type, string? Request);
public record QueueActionResponse(string Message);
public record PurchasableItem(string Name, int MaxDamage, int PurchaseCost, IEnumerable<WeaponRange> Ranges);
