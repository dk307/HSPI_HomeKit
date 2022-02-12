﻿using HomeKit.Utils;
using Newtonsoft.Json;
using System.Collections.Immutable;
using System.Linq;

#nullable enable

namespace HomeKit.Model
{
    internal sealed record Accessory
    {
        public Accessory(ulong aid, IImmutableDictionary<ulong, Service> services)
        {
            Aid = aid;
            Services = services;
        }

        [JsonProperty("aid", Required = Required.Always)]
        public ulong Aid { get; init; }

        [JsonProperty("services")]
        [JsonConverter(typeof(ServiceListConverter))]
        public IImmutableDictionary<ulong, Service> Services { get; init; }

        public string? Name => FindCharacteristic(ServiceType.AccessoryInformation, CharacteristicType.Name)?.Value?.ToString();
        public string? Version => FindCharacteristic(ServiceType.AccessoryInformation, CharacteristicType.Version)?.Value?.ToString();
        public string? Model => FindCharacteristic(ServiceType.AccessoryInformation, CharacteristicType.Model)?.Value?.ToString();
        public string? SerialNumber => FindCharacteristic(ServiceType.AccessoryInformation, CharacteristicType.SerialNumber)?.Value?.ToString();
        public string? FirmwareRevision => FindCharacteristic(ServiceType.AccessoryInformation, CharacteristicType.FirmwareRevision)?.Value?.ToString();

        public Characteristic? FindCharacteristic(ServiceType serviceType, CharacteristicType characteristicType)
        {
            return Services?.Values.FirstOrDefault(x => x.Type == serviceType)
                    ?.Characteristics.Values.FirstOrDefault(x => x.Type == characteristicType);
        }

        public Characteristic? FindCharacteristic(ulong iid)
        {
            if (Services != null)
            {
                foreach (var service in Services)
                {
                    if (service.Value.Characteristics.TryGetValue(iid, out var value))
                    {
                        return value;
                    }
                }
            }

            return null;
        }
    }
}