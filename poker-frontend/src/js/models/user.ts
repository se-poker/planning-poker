import Card from "@/js/models/card";

export default interface User {
  connection: string;
  name: string;
  card: Card | null;
}
