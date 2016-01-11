#Opgave
prey -> food source for the predators.<br>
Both groups have a fixed birthrate.<br>
The prey procreate faster than the predators<br>
But as the population of prey increases -> the habitat support more predators. -> increasing predator population, -> a decreasing prey population -> predator population grows ->  the number of prey can no longer support the present predator population -> predator population begins to wane.<br>
populations continue this interaction of growth and decay.<br>

1. The habitat updates in ticks. One tick -> every animal can do something.
2. Animals can move to adjacent space, if empty. One move per tick.
3. Animals can reproduce. Each animal is assigned a fixed breed time. If the animal lives after breed time ticks of the clock, it will reproduce. The animal does so by finding an unoccupied adjacent space and fills that space with the new animal – its offspring. The animal’s breed time is then reset to zero. An animal can breed at most once in a clock tick.
4. predators must eat -> have a fixed starve time -> If they cannot find a prey to eat before starve time ticks of the clock, they die.
5. When predator eats -> moves to adjacent space with prey -> The prey is removed -> starve reset to zero. Eating counts as the predator’s move during that clock tick.
6. At the end of every clock tick, each animal’s local event clock is updated. All animals’ breed times are decremented and all predators’ starve times are decremented.
