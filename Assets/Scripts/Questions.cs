
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UdonSharp;
using UnityEngine;
using VRC.SDK3.Data;
using VRC.SDKBase;
using VRC.Udon;



class  QuestionsClass
{
    public string en;
    public string de;
    public string zh;
} 
    


public class Questions : UdonSharpBehaviour
{
    public readonly DataDictionary Sets = new DataDictionary()
    {
        { "German", new DataList()
        {
            "1. Wenn Sie die Wahl hätten, wen würden Sie sich als Gast beim Abendessen wünschen?",
            "2. Würden Sie gerne berühmt sein? Auf welche Art und Weise?",
            "3. Haben Sie vor einem Telefonat jemals geprobt, was Sie sagen werden? Weshalb?",
            "4. Was wäre ein \"perfekter\" Tag für Sie?",
            "5. Wann haben Sie zuletzt für sich selbst gesungen? Für jemand anderen?",
            "6. Wenn du 90 Jahre alt werden könntest und die letzten 60 Jahre deines Lebens entweder den Geist oder den Körper eines 30-Jährigen behalten könntest, was würdest du dir wünschen?",
            "7. Haben Sie eine geheime Vorahnung, wie Sie sterben werden?",
            "8. Nennen Sie drei Dinge, die Sie und Ihr Partner gemeinsam zu haben scheinen.",
            "9. Wofür sind Sie in Ihrem Leben am dankbarsten?",
            "10. Wenn Sie etwas an Ihrer Erziehung ändern könnten, was wäre das?",
            "11. Nehmen Sie sich vier Minuten Zeit und erzählen Sie Ihrem Partner Ihre Lebensgeschichte so detailliert wie möglich.",
            "12. Wenn du morgen aufwachen könntest und eine bestimmte Eigenschaft oder Fähigkeit gewonnen hättest, welche wäre das?",
            "Satz II",
            "13. Wenn eine Kristallkugel dir die Wahrheit über dich, dein Leben, die Zukunft oder etwas anderes sagen könnte, was würdest du wissen wollen?",
            "14. Gibt es etwas, das du schon lange tun wolltest? Warum haben Sie es noch nicht getan?",
            "15. Was ist die größte Errungenschaft deines Lebens?",
            "16. Was schätzen Sie an einer Freundschaft am meisten?",
            "17. Was ist Ihre wertvollste Erinnerung?",
            "18. Welches ist deine schrecklichste Erinnerung?",
            "19. Wenn du wüsstest, dass du in einem Jahr plötzlich sterben würdest, würdest du dann etwas an deinem jetzigen Lebensstil ändern? Und warum?",
            "20. Was bedeutet Freundschaft für dich?",
            "21. Welche Rolle spielen Liebe und Zuneigung in deinem Leben?",
            "22. Nennen Sie abwechselnd etwas, das Sie als positive Eigenschaft Ihres Partners ansehen. Nennen Sie insgesamt fünf Punkte.",
            "23. Wie eng und herzlich ist Ihre Familie? Haben Sie das Gefühl, dass Ihre Kindheit glücklicher war als die der meisten anderen Menschen?",
            "24. Was denken Sie über Ihre Beziehung zu Ihrer Mutter?",
            "Satz III",
            "25. Machen Sie jeweils drei wahre \"Wir\"-Aussagen. Zum Beispiel: \"Wir sind beide in diesem Raum und fühlen ...\"",
            "26. Vervollständigen Sie diesen Satz: \"Ich wünschte, ich hätte jemanden, mit dem ich ... teilen könnte.\"",
            "27. Wenn Sie mit Ihrem Partner oder Ihrer Partnerin eng befreundet wären, teilen Sie ihm oder ihr bitte mit, was für ihn oder sie wichtig wäre, zu wissen.",
            "28. Sagen Sie Ihrem Partner, was Sie an ihm oder ihr mögen. Seien Sie diesmal sehr ehrlich und sagen Sie Dinge, die Sie vielleicht nicht zu jemandem sagen würden, den Sie gerade erst kennengelernt haben.",
            "29. Teilen Sie Ihrem Partner einen peinlichen Moment in Ihrem Leben mit.",
            "30. Wann haben Sie das letzte Mal vor einer anderen Person geweint? Vor sich selbst?",
            "31. Sagen Sie Ihrem Partner etwas, das Sie bereits an ihm/ihr mögen.",
            "32. Was, wenn überhaupt, ist zu ernst, um darüber zu scherzen?",
            "33. Wenn Sie heute Abend sterben würden und keine Möglichkeit hätten, mit jemandem zu kommunizieren, was würden Sie am meisten bedauern, wenn Sie es niemandem gesagt hätten? Warum haben Sie es ihnen noch nicht gesagt?",
            "34. Ihr Haus, in dem sich alles befindet, was Sie besitzen, fängt Feuer. Nachdem Sie Ihre Angehörigen und Haustiere gerettet haben, bleibt Ihnen noch Zeit, einen letzten Versuch zu unternehmen, einen Gegenstand zu retten. Welches wäre das? Und warum?",
            "35. Wessen Tod würde Sie von allen Menschen in Ihrer Familie am meisten beunruhigen? Und warum?",
            "36. Erzählen Sie von einem persönlichen Problem und bitten Sie Ihren Partner um Rat, wie er oder sie damit umgehen könnte. Bitten Sie Ihren Partner auch, Ihnen zu sagen, wie Sie sich in Bezug auf das Problem fühlen, das Sie ausgewählt haben."
        }
        },

        { "Chinese", new DataList()
        {
            "1. 如果可以选择世界上的任何一个人，你希望谁来做晚餐客人？",
            "2. 你想成为名人吗？以何种方式？",
            "3. 在打电话之前，你有没有预演过你要说的话？为什么？",
            "4. 对你来说，什么样的日子才算 \"完美\"？",
            "5. 你最后一次对自己唱歌是什么时候？对别人？",
            "6. 如果你能活到90岁，并在生命的最后60年里保持30岁的头脑或身体，你希望是哪一种？",
            "7. 你对自己的死亡方式有什么秘密预感吗？",
            "8. 说出你和你的伴侣似乎有三个共同点。",
            "9. 在你的生活中，你对什么感到最感激？",
            "10. 如果你能改变你的成长方式，你会怎么做？",
            "11. 用四分钟时间，尽可能详细地告诉你的伙伴你的生活故事。",
            "12. 如果你明天醒来时能获得任何一种品质或能力，你会是什么？",
            "第二套",
            "13. 如果一个水晶球可以告诉你关于你自己、你的生活、未来或其他任何事情的真相，你会想知道什么？",
            "14. 有什么事情是你长期以来梦寐以求的？为什么你没有做呢？",
            "15. 你人生中最大的成就是什么？",
            "16. 你在友谊中最看重什么？",
            "17. 你最珍惜的记忆是什么？",
            "18. 你最可怕的记忆是什么？",
            "19. 如果你知道一年后你会突然死亡，你会改变你现在的生活方式吗？为什么？",
            "20. 友谊对你意味着什么？",
            "21. 爱和亲情在你的生活中扮演什么角色？",
            "22. 交替分享一些你认为你的伴侣的积极特征。共分享五个项目。",
            "23. 你的家庭有多亲密和温暖？你是否觉得你的童年比其他大多数人的童年更幸福？",
            "24. 你觉得你和你母亲的关系如何?",
            "第三套",
            "25. 每人做三个真实的 \"我们 \"陈述。例如，\"我们都在这个房间里，感觉......\"",
            "26. 完成这个句子。\"我希望我有一个人可以和他分享......\"",
            "27. 如果你要和你的伴侣成为亲密的朋友，请分享什么对他或她来说是重要的。",
            "28. 告诉你的伴侣你喜欢他们什么；这次要非常诚实，说一些你可能不会对刚认识的人说的话。",
            "29. 与你的伴侣分享你生活中一个尴尬的时刻。",
            "30. 你最后一次在别人面前哭是什么时候？自己一个人？",
            "31. 告诉你的伴侣一些你已经喜欢他们的事情。",
            "32. 如果有什么事情是太严重而不能开玩笑的？",
            "33. 如果你今天晚上死了，没有机会与人交流，你最后悔没有告诉别人什么？为什么你还没有告诉他们？",
            "34. 你的房子，包括你的一切，起火了。在救出你的亲人和宠物后，你有时间安全地做最后的冲刺，以拯救任何一件物品。那会是什么？为什么？",
            "35. 在你家里所有的人中，你会觉得谁的死亡最令人不安？为什么？",
            "36. 分享一个个人问题，并征求你的伴侣对他或她如何处理这个问题的建议。同时，请你的伴侣向你反映你对你所选择的问题的感觉如何。"
        }
        },

        { "English", new DataList()
        {
            "1. Given the choice of anyone in the world, whom would you want as a dinner guest?",
            "2. Would you like to be famous? In what way?",
            "3. Before making a telephone call, do you ever rehearse what you are going to say? Why?",
            "4. What would constitute a “perfect” day for you?",
            "5. When did you last sing to yourself? To someone else?",
            "6. If you were able to live to the age of 90 and retain either the mind or body of a 30-year-old for the last 60 years of your life, which would you want?",
            "7. Do you have a secret hunch about how you will die?",
            "8. Name three things you and your partner appear to have in common.",
            "9. For what in your life do you feel most grateful?",
            "10. If you could change anything about the way you were raised, what would it be?",
            "11. Take four minutes and tell your partner your life story in as much detail as possible.",
            "12. If you could wake up tomorrow having gained any one quality or ability, what would it be?",
            "Set II",
            "13. If a crystal ball could tell you the truth about yourself, your life, the future or anything else, what would you want to know?",
            "14. Is there something that you’ve dreamed of doing for a long time? Why haven’t you done it?",
            "15. What is the greatest accomplishment of your life?",
            "16. What do you value most in a friendship?",
            "17. What is your most treasured memory?",
            "18. What is your most terrible memory?",
            "19. If you knew that in one year you would die suddenly, would you change anything about the way you are now living? Why?",
            "20. What does friendship mean to you?",
            "21. What roles do love and affection play in your life?",
            "22. Alternate sharing something you consider a positive characteristic of your partner. Share a total of five items.",
            "23. How close and warm is your family? Do you feel your childhood was happier than most other people’s?",
            "24. How do you feel about your relationship with your mother?",
            "Set III",
            "25. Make three true \"we\" statements each. For instance, \"We are both in this room feeling ...\"",
            "26. Complete this sentence: \"I wish I had someone with whom I could share ...\"",
            "27. If you were going to become a close friend with your partner, please share what would be important for him or her to know.",
            "28. Tell your partner what you like about them; be very honest this time, saying things that you might not say to someone you’ve just met.",
            "29. Share with your partner an embarrassing moment in your life.",
            "30. When did you last cry in front of another person? By yourself?",
            "31. Tell your partner something that you like about them already.",
            "32. What, if anything, is too serious to be joked about?",
            "33. If you were to die this evening with no opportunity to communicate with anyone, what would you most regret not having told someone? Why haven’t you told them yet?",
            "34. Your house, containing everything you own, catches fire. After saving your loved ones and pets, you have time to safely make a final dash to save any one item. What would it be? Why?",
            "35. Of all the people in your family, whose death would you find most disturbing? Why?",
            "36. Share a personal problem and ask your partner’s advice on how he or she might handle it. Also, ask your partner to reflect back to you how you seem to be feeling about the problem you have chosen."
        }
        }
    };
}
