# RaidManagement
This is a solution that includes a desktop application, a database, and a reporting website for handling all ascepts of
raiding in the MMORPG game, Everquest. This will handle the awarding of DKP, attendance, with the ability to handle 
waitlists or split raids taking bids of multiple items simultaneously and determining the winning bid based on rules and 
tiebreaking rules. Will require human confirmation of winning bids. Will have the ability to warn if a single players who 
wins multiple bids exceeds his earned amount. Winning bids amounts will in real-time will be deducted from player's account. 

The website is primarily to display for all players, main and alts, their current DKP, 30/60/90 attendance percentages.
Main Characters, dkp, and attendance percentage column are sortable.  Players will also be able to be grouped by class, 
Armor ie Plate, chain, leather, silk, and Class Type: Tank, Healer, melee, hybrid. Website will also be able to search 
for previously won items and view who won it, for how much and when did they win it.

One will have to change the configuration string in the app.config file as it points to an azure database.
