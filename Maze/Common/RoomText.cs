namespace Maze.Common
{
    using System.Collections.Generic;

    /// <summary>
    /// The text for each room.
    /// </summary>
    public class RoomText
    {
        #region Fields

        private static readonly Dictionary<int, string> RoomTexts = new Dictionary<int, string>
        {
            {
                0,
                "The Maze." 
                + "\n\n      I met them at the gate though I usually wait inside. Preoccupied with their own throughts, impatient, like so many children, they didn\'t see who I really was. They never noticed my crown, my pain, the fire in my eyes."
                + "\n      Like all others they think the Maze was made for them; actually, it is the other way around. They think I am some poet who will lead them through the symbols and spaces of this Underworld. They think I will teach them lessons. They should call me Cerberus...I am the lesson." 
                + "\n      The monstrous walls rise up and run away as far as the human eye can see, circling and dividing. Which half is the Maze?" 
                + "\n      Even I get lost. It changes - sometimes slowly, imperceptibly... sometimes suddenly. This House is not only made of stone and mortar, wood and paint; it is made of time and mystery, hope and fear. Construction never stops. I take some pride in my role as architect." 
                + "\n      They think I will guide them to the center. Perhaps I will..." 
                + "\n      The sun was very hot."
                + "\n      Together we walked through the gate into..."
            },
            {
                1,
                "...the entrance hall of the Maze." 
                + "\n      They looked carefully at the bronze doors, trying to choose. The uncertainty of visitors is one of my little pleasures." 
                + "\n      \"It\'s easy to get lost,\" I said helpfully. \"This can be a sinister place.\" The sun glared at me through the gateway." 
                + "\n      Something was ringing behind one of the doors. They spent some time trying to decide which door it was, not understanding that the silences of the Maze are as eloquent as the sounds." 
                + "\n      \"Decisions, decisions,\" one said. \"Too many decisions.\"" 
                + "\n      \"The story of my life,\" said another."
                + "\n      \"We don\'t want to be late,\" said a third, opening one of the doors." 
                + "\n      \"Nary a soul to be seen,\" said the first, peering into the gloom." 
                + "\n      I waited patiently for them to choose which way to go... into..."
            },
            {
                2,
                "...a bright room whose walls were in some disrepair."
                + "\n      The floorboards creaked and groaned; the plaster made a gritty sound."
                + "\n      They studied the old frescoes for clues but missed the obvious signs."
                + "\n      \"Are we on the right path?\" they asked."
                + "\n      Keeping in mind what a relative term \"right\" is, I assured them they were, indeed, on the right path. As for the \"correct\" path of the \"most appropriate\" path.... Well, that might be something else."
                + "\n      Full of confidence now they marched out to..."
            },
            {
                3,
                "...an entirely different kind of place." 
                + "\n      The group complained of feeling \"all turned around,\" as well they might."
                + "\n      Because no one wanted to stay here very long they missed the real sign while looking through the obvious. People in their situation, confronted with a challenge, tend to accept the terms of the challenge as a given, without examining it from all sides. How many sides does that problem have? They don\'t know."
                + "\n      We passed down a long flight of stairs, through some sort of pantry, and on into..."
            },
            {
                4,
                "...the great hall of many doors."
                + "\n      \"What a foolish face,\" I snorted. \"Pay no attention.\""
                + "\n      A sound made them all turn suddenly. A small black cat ran out of a door to my right, sniffed at us, and, before I could move, ran out of the hall. It was fortunate that I was still standing with the rest of them or they might have noticed."
                + "\n      Faint voices came down one of the corridors."
                + "\n      \"Shall we toss a coin?\" I asked. \"Or have you made up your minds?\""
                + "\n      They hadn\'t made up their minds, and they had no coins. By a process of elimination they decided to go to..."
            },
            {
                5,
                "...the tree room."
                + "\n      \"Are these real?\" they asked."
                + "\n      I told them the trees were as real as anything else in the House. As this was an important decision I encouraged them to take their time. After all, the more they think about the possibilities the more choices they have to make."
                + "\n      What were their chances of choosing wisely... one in four? Two in four perhaps, if I was generous about it... and why not be generous? There are one hundred ninety doors in this part of the House, counting the gate...enough for everyone."
                + "\n      Making a choice, they entered a very long, dark corridor and at last came out into..."
            },
            {
                6,
                "...a gloomy, cavelike place far underground."
                + "\n      Even I was oppressed by the weight that hung over our heads. A very small hole, high above, admitted a feeble light."
                + "\n      Standing in the light one of them put his hand out. \"I think it may be raining out there...\""
                + "\n      They didn\'t like the look of the place."
                + "\n      \"You continue to judge everything by the way it looks!\" I cried, exasperated by their timidity. I knew I shouldn\'t have said anything. If you think of all the deceptions practiced in my family, particularly on my father..."
                + "\n      We went down the only way open to us and came to..."
            },
            {
                7,
                "...a pleasant room with three doors and a lamp."
                + "\n      Looking at the picture on the wall they decided it wasn\'t a very good likeness."
                + "\n      One of them almost fell over something on the floor. \"Why don\'t they pick up after themselves?\" he said, sounding like an old man."
                + "\n      \"Weren\'t you ever irresponsible?\" I asked, thinking of my childhood and how wild I had been."
                + "\n      Music was being played somewhere nearby. We stopped to listen for a moment."
                + "\n      Leaving the pictures looking out at an empty room we went on to..."
            },
            {
                8,
                "...a vaulted chamber lit by a single bulb."
                + "\n      Someone knocked a bowl off the table. The crash echoed from the ceiling and whispered away down the corridors. I broke another on purpose."
                + "\n      \"Make sure to take that with you,\" I said. \"You can never tell when you might need it.\""
                + "\n      \"Take what?\" they wanted to know."
                + "\n      \"Isn\'t it obvious?\"" 
                + "\n      Taking a vote among themselves they went on to..."
            },
            {
                9,
                "...what appeared to be an old storeroom."
                + "\n      Dust obscured a damaged painting making it hard to understand just what the artist had intended."
                + "\n      \"This could be a trick of some sort,\" one said. \"We might be going around in circles.\""
                + "\n      \"I don\'t think so,\" said the thoughtful one. \"I think we\'re supposed to think it\'s a trick... that\'s the trick.\""
                + "\n      They all looked at me. \"Yes,\" I said. \"I\'m sure you\'re right about that.\""
                + "\n      With doubtful looks they left for..."
            },
            {
                10,
                "...a room that smelled of paint."
                + "\n      Faint voices, apparently in an argument, came from behind the locked door."
                + "\n      \"You know,\" said one, \"that sounds like us in there...\""
                + "\n      They tried the door but, naturally, it wouldn\'t open. The voices stopped when the doorknob rattled."
                + "\n      One picked up the umbrella. \"It may rain where we\'re going.\""
                + "\n      I signaled my approval and, after a short rest, we came to..."
            },
            {
                11,
                "...an airy room with many doors."
                + "\n      It was a big space, but I still felt crowded. I\'ve always hated confinement."
                + "\n      \"Whatever you do,\" I warned them, \"don\'t touch that!\""
                + "\n      \"This must be an important room,\" said one of them. \"It has more doors than any of the others...\""
                + "\n      This was not true, but I didn\'t want to interrupt."
                + "\n      \"With so many paths crossing here we must be close to the center,\" she continued."
                + "\n      I had noticed this guest before; I would have to be careful. \"This is an important choice,\" I said, trying to encourage them."
                + "\n      Gratefully leaving the room behind we walked all the way to..."
            },
            {
                12,
                "...a spacious room with a hole in the floor."
                + "\n      A ladder led down into the shadows. Outside, leaves shook in the wind. They didn\'t like the look of that hole in the floor."
                + "\n      \"Too dark down there!\" they cried. \"Who knows what\'s at the bottom.\" They looked at me again."
                + "\n      \"Probably a room of some kind,\" I volunteered quickly. \"But you know what I say about appearances.\" It would have been a relief to get outside for a while."
                + "\n      They wanted to know if they had been here before... How could I answer that?"
                + "\n      \"I have the strangest feeling of déjà vu,\" said one who, bolder than the rest, led us into..."
            },
            {
                13,
                "...room Thirteen."
                + "\n      They weren\'t really comfortable here and I knew why."
                + "\n      \"No, no,\" they said. \"We\'re not all superstitious.\""
                + "\n      \"Only some of you, then?\""
                + "\n      They were worried it might be Friday. Well it\'s true that is was closer to the end of the week than they realized. It takes a great deal of experience, certainly more than they possessed, to understand how time works in the Maze. The clock thought it was six in the evening."
                + "\n      Quickly moving on we came to..."
            },
            {
                14,
                "...one of the biggest rooms in the House."
                + "\n      All three doorways were dark."
                + "\n      \"Afraid to go out?\" I asked."
                + "\n      Since they tried to think of themselves as adults, they didn\'t care for my question."
                + "\n      \"Not really,\" said the thoughtful one, \"but that doesn\'t mean we have to go running around out there just to prove something to you.\""
                + "\n      I knew she would bear watching."
                + "\n      \"Choose then!\" I cried, as if my feelings were hurt. \"Pay no attention to anything I say.\" I knew they couldn\'t afford not to listen to me entirely... they were so easily led."
                + "\n      Turning around, the group took a path that completely surprised me after all, and I followed them to..."
            },
            {
                15,
                "...room number Fifteen."
                + "\n      Just as we entered I heard a thump and the sound of footsteps hurrying away. Somewhere a door slammed."
                + "\n      \"At least three of us can sit down here,\" said one."
                + "\n      There were only three possible choices."
                + "\n      Leaning on the sacrificial tripod I was suddenly moved to say, \"Perhaps these numbers relate to each other in some specific combination...\" Immediately I regretted this act of charity... sometimes I think, after all these years, that I don\'t really know myself."
                + "\n      One of them thought he had worked it out and, very pleased with himself, led us into..."
            },
            {
                16,
                "...a stone chamber which reminded me of my old neighbors."
                + "\n      Of course, that was a long time ago now, but would you believe their decendants are still telling stories about me and my family to their children?"
                + "\n      Even if most of the stories are lies and exaggerations, it is immortality of a sort."
                + "\n      As I passed in front of an open doorway a figure, crossing the hall outside, saw me and immediately ran off."
                + "\n      \"Who was that?\" they asked."
                + "\n      \"Another visitor, to be sure.\""
                + "\n      \"Why did he run away?\""
                + "\n      \"You probably scared him,\" I said, and they apparently believed me."
                + "\n      With few regrets on my part we left for..."
            },
            {
                17,
                "...a room with a floor of sand."
                + "\n      \"Amphorae,\" I pronounced; empty, of course."
                + "\n      \"This is an easier choice to make,\" they said."
                + "\n      \"You may think so,\" I muttered to myself, \"but your choices are more limited than you know.\""
                + "\n      One should never accept the obvious here. If you think of the Maze as a machine, confusion is its product, and the machine was hard at work."
                + "\n      Ignoring my good advice they hurried into..."
            },
            {
                18,
                "...a much warmer room."
                + "\n      Shadows danced across the floor to fire\'s music."
                + "\n      \"Someone\'s lost his hat.\""
                + "\n      \"Are you sure it\'s the hat that is lost?\" I asked reasonably enough. No one would answer me."
                + "\n      Ducking behind a curtain and hurrying down a passageway we came out in ..."
            },
            {
                19,
                "...a shaded portico."
                + "\n      A late afternoon sun warmed the rough blocks of stone."
                + "\n      \"Get out of the way!\" someone called. We moved into the yard, squinting at the strong light."
                + "\n      One of them sat on a marble bench after I politely pushed some flowers aside. \"Did you pick these for me?\" she asked, looking me in the eye. I had to tell her the truth."
                + "\n      In another part of the grounds someone was singing, but they couldn\'t make out the words. Like children they soon became restless and impatient to see something new, so we went on to..."
            },
            {
                20,
                "...room number Twenty."
                + "\n      The ringing stopped as soon as we entered."
                + "\n      \"What is the matter now?\" I asked them."
                + "\n      \"Too many animals for a proper house!\""
                + "\n      They walked carefully around the edges of the room. I watched with an amusement shared, I think, by the wise old tortoise."
                + "\n      With backwards looks and muttered comments about turtles they left room number Twenty and entered..."
            },
            {
                21,
                "...a yard containing shrubs trimmed in ornamental shapes."
                + "\n      \"This,\" I began, \"is called...\""
                + "\n      \"We know what the name is,\" they interrupted. \"Why don\'t you just tell us which way to go?\""
                + "\n      \"I wasn\'t referring to the plants,\" I said in a huff. I refused to say anything else, leaving them to find their own way to..."
            },
            {
                22,
                "...a gaudy room that reminded me of a theatrical backdrop."
                + "\n      Places like this are overdone, for my taste, but some people like the exotic... well, everyone is a critic."
                + "\n      It\'s true, I am by nature extremely critical. Although my life is a lonely one I have not spared any of my guests the rigor of my judgment.... We all have our roles to play."
                + "\n      This is not a bad place, really; one could spend quite some time here. However, in their restive way, the group moved on to..."
            },
            {
                23,
                "...a room with three other doors."
                + "\n      Looking out the windows my feet crushed something on the floor."
                + "\n      \"Watch your step here,\" I warned them. I\'m always ready to be helpful with the less important things."
                + "\n      \"Look at those two trees out there,\" one said, looking over my shoulder, which is not easy to do."
                + "\n      \"Must be a real wind coming up.\""
                + "\n      Now they realized that it could rain where they were going."
                + "\n      \"We should have brought that bumbershoot with us from the coat room...\""
                + "\n      \"Which room was that?\""
                + "\n      \"You remember, the one with the animal...\""
                + "\n      I suggested that we take the door on my right and they realized they had found the door they had been seeking for so long, the entrance to..."
            },
            {
                24,
                "...a place of unlimited darkness."
                + "\n      \"Where are the doors?\" they asked nerviously. \"We can\'t see any doors...\""
                + "\n      \"Be careful where you step!\" said a cold voice. \"This spot is taken.\" Dozens of eyes blinked at us in the Stygian gloom."
                + "\n      By the time my uncertain visitors turned to ask me what to do I was already far away."
                + "\n      \"There are no doors,\" said the voice. \"You are here with the rest of us now...\""
                + "\n      Even my bellowing laughter couldn\'t fill this space."
            },
            {
                25,
                "...a high room with the image of a crown on the wall for everyone to see now."
                + "\n      Though one of my parents might be lowborn, the other was close to a king.... I\'ve always felt at home here."
                + "\n      \"Which door ought we take?\" they wanted to know. I rather brusquely indicated the three doors."
                + "\n      \"Any of those is fine for my purposes.\""
                + "\n      They were disconcerted at the apparent lack of clues. \"Perhaps in another room,\" they said, leaving for..."
            },
            {
                26,
                "...a dramatic room with four entrances and exits."
                + "\n      \"Not enough light in here,\" they remarked. \"Not very tidy either.\""
                + "\n      \"Which way now, children?\" I asked in my most patronizing voice."
                + "\n      They objected to my tone, but it distracted them from the real clues. The game usually goes as I plan it, despite the intentions of my visitors, or perhaps because of their intentions."
                + "\n      \"What the devil is this supposed to be?\" one asked. They gathered around and I realized they were close to something. I quickly picked up the bell, ringing it loudly."
                + "\n      \"Was this what you heard outside?\"" + "\n      Holding their ears they ran out the door to..."
            },
            {
                27,
                "...a darkened chamber dominated by a large figure."
                + "\n      We could see that someone had been working here recently; the entrance I had so carefully hidden had been uncovered. I made a note to return as soon as I could and fill in the hole again."
                + "\n      The visitors were so intrigued with the entrance at the bottom of the excavation that they ignored what the figure was trying to tell them."
                + "\n      \"Where are the workmen?\""
                + "\n      \"They must be ahead of us,\" I said. \"If we hurry we can catch them... I mean catch up with them.\""
                + "\n      I herded the group through the door to..."
            },
            {
                28,
                "...a spacious room with a hole in the floor."
                + "\n      A ladder led down into the shadows. Outside, leaves shook in the wind. They didn\'t like the look of that hole in the floor."
                + "\n      \"Too dark down there!\" they cried. \"Who knows what\'s at the bottom.\" They looked at me again."
                + "\n      \"Probably a room of some kind,\" I volunteered quickly. \"But you what I say about appearances.\" It would have been a relief to get outside for a while."
                + "\n      They wanted to know if they had been here before.... How could I answer that?"
                + "\n      \"I have the strangest feeling of déjà vu,\" said one who, bolder than the rest, led us into..."
            },
            {
                29,
                "...a much smaller room."
                + "\n      A person with a white staff turned to face us. His associate shrugged, not an easy thing to do in his position, and went back to what he had been doing."
                + "\n      \"Look, look,\" said the person with the staff. \"This is very important...\""
                + "\n      I snatched the paper from his hand and tore it into pieces."
                + "\n      \"How will he find his way without directions?\" the group wanted to know."
                + "\n      \"Don\'t worry,\" said the man, \"here blindness is no disadvantage.\""
                + "\n      I hurried my visitors out as quickly as I could to..."
            },
            {
                30,
                "...room number Thirty."
                + "\n      \"What a beautiful door... the others are so plain,\" said one."
                + "\n      \"It\'s meant to influence our decision,\" said another."
                + "\n      \"Perhaps this has been done so we will not choose this door,\" said the thoughtful one."
                + "\n      They wanted to know what the letters meant. Obviously they meant something, and I said so."
                + "\n      \"Yes, but...why \'O\' and \'U\'? What special significance can they have for us?\""
                + "\n      The more confused they became, the more I enjoyed it. No matter how many times I\'ve been through this I\'m always fascinated."
                + "\n      Leaving the room and all that it contained behind us, we entered..."
            },
            {
                31,
                "...a melancholy little courtyard surrounded by a brick wall too high to see over."
                + "\n      A dead tree lifted its bone-white branches to a sky filling with gray clouds."
                + "\n      \"Those doors look very strange,\" they said."
                + "\n      \"You should say, \'They look very strangely,\'\" I corrected."
                + "\n      \"They seem to be watching us...\""
                + "\n      A sudden gust of wind made the branches clatter against each other like old boards. Dead leaves began to gather at our feet."
                + "\n      Shivering in the wind we managed to push open one of the heavy doors and make our way to..."
            },
            {
                32,
                "...a large square room with a hole rudely broken through one wall."
                + "\n      It must have taken a great deal of strength to pull the heavy stones out of position." 
                + "\n      The symmetry was also disturbed by the apparent loss of one of the room\'s statues. My visitors thought a thief had broken into the room, removed the figure, and made away with it. This, of course, was one explanation."
                + "\n      \"Another one!\" they cried."
                + "\n      \"You mean another representative of the animal kingdom?\" I asked."
                + "\n      \"What is a bird like that doing here?\""
                + "\n      \"Roosting, evidently.\" Their attitude was really beginning to irritate me. I have come to think of all the inhabitants of this House as members of my little kingdom. People can be so arrogant...in a very real way we are all animals, at least in part."
                + "\n      I wouldn\'t answer any more of their questions so we left this room to enter..."
            },
            {
                33,
                "...the room with no floor."
                + "\n      They crowded each other on the narrow ledge. The bold one ventured out to the center."
                + "\n      Realizing that they could see all of the signs only from the center of the room, several wanted to turn back."
                + "\n      With exaggerated caution, considering their predicament, they finally reached the door they wanted and eventually found themselves in..."
            },
            {
                34,
                "...a middle-class drawing room or parlor."
                + "\n      It was amazing how much more comfortable they felt in these surroundings."
                + "\n      Everyone sat down, some on the floor, and chatted about where they had been and where they should go."
                + "\n      \"Magpies!\" I said to myself. \"Not a real thought in their heads.\""
                + "\n      They were so much at ease they almost missed what the room was telling them altogether. They finally got the message, which I thought was pretty obvious, and we went on to..."
            },
            {
                35,
                "...what appeared to be someone\'s basement."
                + "\n      One of them sank gratefully down on an old couch which prompty collapsed."
                + "\n      I tried to hide my smile."
                + "\n      \"A totem, or tribal fetish,\" said one, walking around the center of the room."
                + "\n      \"It could be a work of art,\" suggested another."
                + "\n      \"Perhaps it\'s a signal to us,\" the thoughtful one said. \"A warning or direction?\""
                + "\n      \"Not much help when there is only one way to go,\" put in another."
                + "\n      \"I still think it\'s a signal.\""
                + "\n      \"Yes,\" I said right away, \"I\'m sure you\'re right.\""
                + "\n      She was immediately suspicious. Still, with no real choice to make, we left the thing standing alone in light and silence, and went into..."
            },
            {
                36,
                "...an old and ruinous part of the House."
                + "\n      Turning a corner the music we had been hearing became louder and at last we saw the musicians themselves."
                + "\n      They were so involved they failed to hear us. The music was suited to the scene - a moody, romantic melody. We stopped to listen and I admit that I, too, was affected by the sound as well as by the spectacle of the masked players."
                + "\n      One of the visitors noticed me listening. \"Beautiful music, don\'t you think?\""
                + "\n      \"It\'s not bad,\" I said stiffly. \"The viol brings the right sense of warmth to the piece, but the guitarist is overplaying his part. Still, he adds a certain plangent brio to an otherwise introspective composition...\""
                + "\n      Unwilling to interrupt the concert we slipped past the musicians into the door to..."
            },
            {
                37,
                "...a long, open room with no roof." 
                + "\n      \"What is going on here?\" they wondered."
                + "\n      \"Sometimes, important messages are couched in ambiguous terms,\" I said. \"That net may help you catch the answer to your question.\""
                + "\n      They looked doubtful. \"We must look at this from all sides before we make a decision.\" At last, they were learning."
                + "\n      They really couldn\'t decide which way to go; half of them wanted to go one way, half another. They were close to splitting up when there was a rattling sound and one of the doors was shaken from the other side."
                + "\n      They all stopped talking and moved closer together. They soon agreed on a direction and we departed for..."
            },
            {
                38,
                "...a narrow space where one wall boasted half-finished carving and another some sort of carnival poster."
                + "\n      There was a little confusion as we made our entrance but we soon sorted ourselves out."
                + "\n      It was impossible to climb up the slippery slide and another door wouldn\'t open for us, so after emptying the pebbles from our shoes, we marched on to..."
            },
            {
                39,
                "...what looked like a combination wine cellar and junk room."
                + "\n      Someone had been working here as well."
                + "\n      \"This is more to my taste,\" said one, dusting off some labels. All the bottles turned out to be empty."
                + "\n      \"I hear someone hammering,\" said one." 
                + "\n      \"No, that\'s a chopping sound,\" said another."
                + "\n      None of them heard the faint jingling that came from behind the wall. \"I don\'t hear anything,\" I said loudly and, with as much commotion as possible, hurried them out of the room to..."
            },
            {
                40,
                "...the foundation of the Maze."
                + "\n      Deep underground stones had been carved and fitted; passages opened in the natural rock."
                + "\n      \"These symbols are quite unusual,\" said one. \"They seem to be primitive signs...\""
                + "\n      \"Do you know what signs?\" I asked him."
                + "\n      \"Oh, you know... wind and water, hills and planets.\""
                + "\n      It was surprising that he could identify any of the symbols, but I was relieved that he couldn\'t read them correctly."
                + "\n      Choosing more or less at random they went through a passageway to..."
            },
            {
                41,
                "...a room with a special piece of furniture I thought might appeal to my guests."
                + "\n      \"How can we trust that thing?\" one remarked. \"Who knows where it ends up...\""
                + "\n      I knew naturally, but that wasn\'t the point. They were pretty sure of themselves, and went right on to..."
            },
            {
                42,
                "...the next room."
                + "\n      In one corner a savage animal appeared ready to leap out, roaring, rending with tusk and claw... but it was only a bit of taxidermy after all."
                + "\n      I suggested they might wish to hang up their coats before going on."
                + "\n      \"How will we find them?\" one asked. \"We might not pass through here again.\""
                + "\n      I assured them I would help them to return. \"You can count on me,\" I said sincerely. Still, they wouldn\'t leave anything behind."
                + "\n      Opening one of the doors we made our way to..."
            },
            {
                43,
                "a great hall dominated by the entrance to room Twenty-Two."
                + "\n      The face over the door had a sly look."
                + "\n      \"Is it good or bad to have only two choices?\" they wanted to know."
                + "\n      It was, predictably enough, neither \"good\" not \"bad.\" These people just didn\'t know how to phrase a meaningful question. You have to be very particular in this House."
                + "\n      We went on to..."
            },
            {
                44,
                "...a courtyard of palms and statues."
                + "\n      The trees waved to each other in the breeze."
                + "\n      \"Who left the door open?\" they wanted to know."
                + "\n      \"We came in that way,\" I offered, but they were convinced we had entered by another door entirely."
                + "\n      They vanished through the wall and I followed them to..."
            },
            {
                45,
                "...the room at the center of the Maze."
                + "\n      My guests thought that whoever lived here was a careless person, to leave so many things around. They were wrong."
                + "\n      There was really only one thing for them to find: the Riddle of the Maze. They demanded that I show it to them."
                + "\n      \"Do you think it is written on the wall for all to see? It is hidden here, somewhere, perhaps throughout the room. As far as you are concerned, what the Maze teaches can be learned in every room.\""
                + "\n      They looked and looked... every group is the same."
                + "\n      \"Now,\" I said, after a last look around, \"we must find our way back out.\""
                + "\n      Leaving the center of the Maze we found ourselves in..."
            }
        };

        #endregion // Fields

        #region Methods

        /// <summary>
        /// Gets the room's text.
        /// </summary>
        /// <param name="roomNum">The room number.</param>
        /// <returns>The room's text.</returns>
        public static string GetRoomText(int roomNum)
        {
            if (RoomTexts.ContainsKey(roomNum))
            {
                return RoomTexts[roomNum];
            }

            return string.Empty;
        }

        #endregion // Methods
    }
}
