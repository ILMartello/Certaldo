using System;
using System.Collections.Generic;
using Parallelo.Data;
using Parallelo.Maps;
using Xamarin.Forms;
using System.Linq;
using System.IO;
using Xamarin.Essentials;
using Certaldo.Models;

namespace Certaldo.Models
{
    public class DatasourceModel : BaseDatasourceModel
    {
        public List<Place> Places { get; set; }
    }

    public class Image
    {
        public string File { get; set; }
    }

    public class PlaceTranslation
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string locale { get; set; }
    }

    //Palazzo
    public class RoomTranslation
    {
        public int id;
        public int casa_palazzo;
        public string Title { get; set; }
        public string Description { get; set; }
        public string locale { get; set; }
    }

    public class Room : BaseLocalizedEntityModel
    {
        public int id;
        public string Type;
        //public string CoverPhoto;/*?*/
        public int plan;
        public int room_number;
        public string tag;/*?*/
        //public int Beacon;
        public string Link;
        public string Color;/*?*/
        //public bool published;
        public DateTime created_at;
        public DateTime updated_at;
        //Pivot
        public List<RoomTranslation> translations { get; set; }
        public override IDictionary<string, object> Translations => translations.ToDictionary(tr => tr.locale, tr => (object)tr);
        public List<Image> photos { get; set; }
        public List<ImageSource> Immagini => photos.Select(photo => ImageSource.FromFile(Path.Combine(FileSystem.AppDataDirectory, "Photos", photo.File))).ToList();
        public ImageSource Immagine => photos.Count == 0 ? null : ImageSource.FromFile(Path.Combine(FileSystem.AppDataDirectory, "Photos", photos.FirstOrDefault().File));
        //Calendar?
    }
    //Fine palazzo


    //Evento
    public class EventTranslation
    {
        public int id;
        public int casa_palazzo;
        public string Title { get; set; }
        public string Description { get; set; }
        public string locale { get; set; }
    }
    public class Event : BaseLocalizedEntityModel
    {
        public int id { get; set; }
        public string dataInizio { get; set; }
        public string dataFine { get; set; }
        public int hour;
        public int minutes;
        public List<EventTranslation> translations { get; set; }
        public override IDictionary<string, object> Translations => translations.ToDictionary(tr => tr.locale, tr => (object)tr);
        public List<Image> photos { get; set; }
        public List<ImageSource> Immagini => photos.Select(photo => ImageSource.FromFile(Path.Combine(FileSystem.AppDataDirectory, "Photos", photo.File))).ToList();
        public ImageSource Immagine => photos.Count == 0 ? null : ImageSource.FromFile(Path.Combine(FileSystem.AppDataDirectory, "Photos", photos.FirstOrDefault().File));
        public Place MyPlace { get; set; }//Aggiunto per collegare evento a luogo (pin)

    }
    //Fine Evento

    public class Place : BaseLocalizedEntityModel
    {
        public int id { get; set; }
        public string Beacon { get; set; }
        public string Type { get; set; }
        public List<Image> photos { get; set; }

        public List<PlaceTranslation> translations { get; set; }
        public float Longitudine { get; set; }
        public float Latitudine { get; set; }
        public override IDictionary<string, object> Translations => translations.ToDictionary(tr => tr.locale, tr => (object)tr);
        public ImageSource Immagine => photos.Count == 0 ? null : ImageSource.FromFile(Path.Combine(FileSystem.AppDataDirectory, "Photos", photos.FirstOrDefault().File));
        public List<ImageSource> Immagini => photos.Select(photo => ImageSource.FromFile(Path.Combine(FileSystem.AppDataDirectory, "Photos", photo.File))).ToList();

        // Palazzo
        public List<Room> casapalazzo { get; set; }
        public Dictionary<int, List<Room>> Piani => casapalazzo.GroupBy((room) => room.plan).ToDictionary((group) => group.Key, group => group.ToList());
        public bool HasPiani => casapalazzo.Count > 0;

        //Evento
        public List<Event> calendars { get; set; }
    }
}
