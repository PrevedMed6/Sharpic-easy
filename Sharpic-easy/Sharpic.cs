using Sharpic_easy.Enums;
using Sharpic_easy.Models;
using Sharpic_easy.Repositories;

namespace Sharpic_easy
{
    internal class Sharpic
    {
        #region fields
        internal delegate void EnterHandler(string message);
        internal event EnterHandler? Reply;
        internal Sharpic(EnterHandler enterHandler) {
            Reply += enterHandler;
        }
        private static readonly FakeMessageRepo messageRepo = new FakeMessageRepo();
        private static readonly FakeReplyRepo replyRepo = new FakeReplyRepo();
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
            List<Reply> replies = replyRepo.GetByType(phraseType);
            var rnd = new Random();
            rnd.Next(replies.Count);
            return replies.ElementAt(rnd.Next(replies.Count))?.ReplyMessage ?? NoReply;
        }
        private string GetPhraseType(string enteredWord)
        {
            return messageRepo.GetTypeByPart(enteredWord);
        }
        #endregion
    }
}
