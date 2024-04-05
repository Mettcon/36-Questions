
using UdonSharp;
using UnityEngine;
using VRC.SDK3.Data;
using VRC.SDKBase;
using VRC.Udon;

public class Intro : UdonSharpBehaviour
{
    public readonly DataDictionary Sets = new DataDictionary()
    {
        { "German", new DataList()
        {
            "Diese Fragen basieren auf den psychologischen Forschungen von Arthur Aron und sollen die Intimität zwischen zwei Menschen fördern.\r\n\r\nDie Serie ist in drei Sätze unterteilt, von denen jeder tiefer in die Materie eindringt als der letzte. Der Grundgedanke ist, dass gegenseitige Verletzlichkeit die Nähe fördert. Diese Fragen ermutigen zu Offenheit und Selbstoffenbarung, aber es ist wichtig, dass Sie immer Ihr Wohlbefinden und Ihre Grenzen in den Vordergrund stellen.\r\n\r\nEs ist wichtig, darauf hinzuweisen, dass diese Studie zwar als Methode des \"Verliebtseins\" an Popularität gewonnen hat, dass es aber ursprünglich mehr um das Verständnis von Intimität und engen Beziehungen ging. Das Konzept des Verliebtseins durch dieses Experiment ist eine sensationelle Interpretation und nicht der eigentliche Anspruch der Studie."
        }
        },

        { "Chinese", new DataList()
        {
            "这些问题基于亚瑟-阿隆的心理学研究，旨在加速两人之间的亲密关系。\r\n\r\n该系列问题分为三组，每一组都比上一组更具有探究性，其基本理念是相互的脆弱性能促进亲密关系。这些问题鼓励开放和自我披露，但重要的是要始终优先考虑自己的舒适度和界限。\r\n\r\n值得注意的是，虽然这项研究作为一种 \"恋爱 \"方法而广为流行，但其初衷更多的是为了了解亲密关系和亲密关系。通过这项实验坠入爱河的概念只是一种耸人听闻的解释，而不是这项研究的实际主张。"
        }
        },

        { "English", new DataList()
        {
            "Based on Arthur Aron's psychological research, these questions are designed to accelerate intimacy between two people.\r\n\r\nThe series is divided into three sets, each more probing than the last, with the underlying idea that mutual vulnerability fosters closeness. These questions encourage openness and self-disclosure, but it's important to always prioritise your comfort and boundaries.\r\n\r\nIt's important to note that although this study has gained popularity as a method of 'falling in love', the original intention was more about understanding intimacy and close relationships. The concept of falling in love through this experiment is a sensational interpretation rather than the actual claim of the study."
        }
        }
    };
}

