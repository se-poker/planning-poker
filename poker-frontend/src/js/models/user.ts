import { Card } from "@/js/models/card";

export interface User {
  connection: string;
  name: string;
  card: Card | null;
}
