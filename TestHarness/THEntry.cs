using RoyalDomain.Objects;
using RoyalDomain.Enums;
using TestHarness;

/*
 * 
 */

var _social = SocialTendency.Stoic;

var _delay = DelayTendency.Focused;

var _fidget = FidgetTendency.Relaxed;

var _profile = new Profile(_social, _delay, _fidget);

var _behavior = new Behavior(_profile);

var _logger = new Logger();

_logger.Log("===>In the manicured lawn of the castle grounds<===");

_logger.Log($"The chance for this NPC to speak is {_behavior.ChanceToSpeak}");
