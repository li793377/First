using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBBS.DAL;
using MyBBS.Model;
namespace MyBBS.BLL
{
    public static class CardManager
    {
        public static int addCard(Card card)
        {
            return CardSer.addCard(card);
        }
        public static string getMaxCardID()
        {
            return CardSer.getMaxCardID();
        }
        public static int deleteCard(Card card)
        {
           return CardSer.deleteCard(card);
        }
        public static List<Card> FindCardByMouduleID(Card card)
        {
            return CardSer.FindCardByMouduleID(card);
        }
        public static List<Card> FindCardByCardName(Card card)
        {
            return CardSer.FindCardByCardName(card);
        }
        public static Card FindCardByCardID(Card card)
        {
            return CardSer.FindCardByCardID(card);
        }
        public static List<Card> getAllCard()
        {
            return CardSer.getAllCard();
        }
    }
}
