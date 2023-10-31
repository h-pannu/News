using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.Model;

namespace News.Services
{
    public class MockNewsService
    {
        List<NewsToday> newsList = new()
        {
            new NewsToday() {Title="Trump Is Charged in Classified Documents Inquiry", Content="Donald J. Trump is the first former president in American history to face federal charges. He said he would surrender to the authorities.Credit...Charlie Neibergall/Associated Press", ImageUrl="https://media.cnn.com/api/v1/images/stellar/prod/230209152722-elon-musk-0127.jpg?c=original"},
            new NewsToday() {Title="Gaza population being ‘dehumanized’ UN agency warns as Netanyahu rejects ceasefire calls", Content="Israeli forces rescue soldier held by Hamas in special operation, IDF says\r\nIsraeli troops advance in Gaza, hostage freed and ‘impossible’ hospital evacuation: What to know Monday\r\nUkrainian family of nine shot dead in their sleep in Russian-occupied Donetsk\r\nThai deaths in Hamas massacre spotlight poor agricultural workers from Asia who toil in Israel’s fields\r\nAn anti-Jewish riot in Russia’s Dagestan region shows the risks of Putin’s balancing act on Hamas", ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSlS98VPccHHsBk1m4fQ0CnrrcF5G_saPxjl2l0DYLqktP8jhlXCThxSPSpWHxr9F-fxyw&usqp=CAU"},
            new NewsToday() {Title="Chinese authorities crack down on stray dogs after a Rottweiler mauls a toddler. But some say they’ve gone too far", Content="Hong Kong\r\nCNN\r\n — \r\nA shocking video of a Rottweiler mauling a 2-year-old girl in China has prompted a crackdown by local authorities on stray dogs that some argue has now gone too far.\r\n\r\nAuthorities were initially praised for their swift response to the incident, but netizens soon began sharing accounts of stray canines in their neighborhood being roughly rounded up and, in some cases, put down.\r\n\r\nThe new directive to clamp down on large, unleashed dogs is being cited as the latest example of a knee-jerk reaction by Chinese authorities that also highlights the country’s long-standing struggle with animal rights and welfare.", ImageUrl="https://media.cnn.com/api/v1/images/stellar/prod/231030101544-dogs-china-covid-file.jpg?c=16x9&q=h_720,w_1280,c_fill/f_webp"}
        };

        public List<NewsToday> GetNews()
        {
            return newsList;
        }
    }
}
