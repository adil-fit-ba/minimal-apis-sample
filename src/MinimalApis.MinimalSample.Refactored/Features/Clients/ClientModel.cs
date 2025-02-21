﻿namespace MinimalApis.MinimalSample.Refactored.Features.Clients;

/// <summary>
/// Represents a single client.
/// </summary>
public class ClientModel
{
    /// <summary>
    /// Gets or sets the client id.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the client name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    public static ClientModel FromClient(Client client)
    {
        return new ClientModel
        {
            Id = client.Id,
            Name = client.Name
        };
    }
}
