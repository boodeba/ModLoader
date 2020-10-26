using System;
using System.Numerics;

namespace AmongUs.Api
{
    public static class VotingScreen
    {
        public static event Action<MeetingHud> UpdateEvent;

        public static void Update(MeetingHud hud) => UpdateEvent?.Invoke(hud);
    }

    //Currently unused, wrapper for MeetingHud
    public interface IVotingScreen
    {
        string TitleText { get; set; }
        Vector3 TimerPosition { get; set; }
        Vector3 VotePosition { get; set; }
        Vector3 VoteButtonSize { get; set; }
        PlayerVoteArea SkipVoteButton { get; set; } 
        PlayerVoteArea[] PlayerStates { get; set; }
        //GameData.IHEKEPMDGIJ ExiledPlayer { get; set; }
        bool Tied { get; set; }
        string TimerText { get; set; }
        float DiscussionTime { get; set; }
    }
}
