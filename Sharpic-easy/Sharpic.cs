using Sharpic_easy.Enums;
using Sharpic_easy.Interfaces;
using Sharpic_easy.Models;
using Sharpic_easy.Repositories;

namespace Sharpic_easy
{
    public class Sharpic
    {
        #region fields
        public delegate void EnterHandler(string message);
        public event EnterHandler? Reply;
        public Sharpic(IMessageRepo messageRepo, IReplyRepo replyRepo) {
            _messageRepo = messageRepo;
            _replyRepo = replyRepo;
        }
        private static IMessageRepo _messageRepo;
        private static IReplyRepo _replyRepo;
        private const string NoReply = "Ой, ты меня запутал....";

        private static readonly Dictionary<string, Func<string>> replyMethods = new Dictionary<string, Func<string>>()
        {
            {PhraseTypesEnum.hello.ToString(), SayHello},
            {PhraseTypesEnum.goodBy.ToString(), SayGoodBy},
            {PhraseTypesEnum.joke.ToString(), TellJoke},
            {PhraseTypesEnum.whatsYourName.ToString(), SayYourName},
            {PhraseTypesEnum.currentTime.ToString(), TellCurrentTime},
            {PhraseTypesEnum.aphorism.ToString(), TellAphorism},
        };
        #endregion

        #region public
        internal bool FindReply(string enteredWord)
        {
            string phraseType = GetPhraseType(enteredWord);
            if (replyMethods.ContainsKey(phraseType))
            {
                Reply?.Invoke(replyMethods[phraseType]());
            }
            else
            {
                Reply?.Invoke(NoReply);
            }
            return phraseType != PhraseTypesEnum.goodBy.ToString();
        }
        #endregion

        #region private
        private static string SayHello()
        {
            return GetRandomReply(PhraseTypesEnum.hello.ToString());
        }
        private static string SayYourName()
        {
            return GetRandomReply(PhraseTypesEnum.whatsYourName.ToString());
        }
        private static string TellJoke()
        {
            return GetRandomReply(PhraseTypesEnum.joke.ToString());
        }
        private static string TellCurrentTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
        private static string TellAphorism()
        {
            return GetRandomReply(PhraseTypesEnum.aphorism.ToString());
        }
        private static string SayGoodBy()
        {
            return GetRandomReply(PhraseTypesEnum.goodBy.ToString());
        }
        private static string GetRandomReply(string phraseType)
        {
            List<Reply> replies = _replyRepo.GetByType(phraseType);
            var rnd = new Random();
            rnd.Next(replies.Count);
            return replies.ElementAt(rnd.Next(replies.Count))?.ReplyMessage ?? NoReply;
        }
        private string GetPhraseType(string enteredWord)
        {
            return _messageRepo.GetTypeByPart(enteredWord);
        }
        #endregion
    }
}
