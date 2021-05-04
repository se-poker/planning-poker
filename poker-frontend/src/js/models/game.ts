import User from "@/js/models/user";
import Stats from "@/js/models/stats";

export interface Game {
  name: string;
  users: User[];
  cards: number[];
  voting: boolean;
  stats: Stats[];
}
