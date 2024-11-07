package accesoJSON;

import java.io.Serializable;
import java.util.*;

public class FootballPlayer implements Serializable {

    private int dorsal;
    private String name;
    private List demarcation;
    private String team;

    public FootballPlayer(int dorsal, String name, List demarcation,
            String team) {
        this.dorsal = dorsal;
        this.name = name;
        this.demarcation = demarcation;
        this.team = team;
    }

    // getter y setter

    @Override
    public String toString() {
        return "Dorsal=" + dorsal + ", Name=" + name + ", Demarcation="
                + demarcation + ", Team=" + team;
    }

	public int getDorsal() {
		return dorsal;
	}

	public void setDorsal(int dorsal) {
		this.dorsal = dorsal;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public List getDemarcation() {
		return demarcation;
	}

	public void setDemarcation(List demarcation) {
		this.demarcation = demarcation;
	}

	public String getTeam() {
		return team;
	}

	public void setTeam(String team) {
		this.team = team;
	}
}
