using System;
using Microsoft.AspNetCore.DataProtection;
using Newtonsoft.Json;
using System.Net;
using DeckOfCards.Models;

namespace DeckOfCards.Models
{
	public class DeckOfCardsDAL
	{
        public static DeckOfCardsModel GetDeck() //Adjust code here
        {
            //adjust
            //setup
            string apiKey = Secret.apiKey;
            string url = $"https://deckofcardsapi.com/api/deck/{apiKey}/draw/?count=5";
            //remove api key and store as variable 
            //whatever you need to make that url work

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Converting to json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json = reader.ReadToEnd();
            //takes imported json data and converts into single string to be used in our objects

            //Adjust
            //Convert json to C#
            //Install Newtonsoft.json in nuget packages
            //right click project file in explorer
            DeckOfCardsModel result = JsonConvert.DeserializeObject<DeckOfCardsModel>(json);
            //Deserializing: converting javascript object to C# object
            //C# object type is <ModelName> (triangle brackets)
            return result;
        }

        public static DeckOfCardsModel ReshuffleDeck() //Adjust code here
        {
            //adjust
            //setup
            string apiKey = Secret.apiKey;
            string url = $"https://deckofcardsapi.com/api/deck/{apiKey}/shuffle";
            //remove api key and store as variable 
            //whatever you need to make that url work

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Converting to json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json = reader.ReadToEnd();
            //takes imported json data and converts into single string to be used in our objects

            //Adjust
            //Convert json to C#
            //Install Newtonsoft.json in nuget packages
            //right click project file in explorer
            DeckOfCardsModel result = JsonConvert.DeserializeObject<DeckOfCardsModel>(json);
            //Deserializing: converting javascript object to C# object
            //C# object type is <ModelName> (triangle brackets)
            return result;
        }
    }
}

