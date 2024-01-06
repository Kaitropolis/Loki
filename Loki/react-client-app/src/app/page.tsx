import AnimalClient from "@/api/animal-client";
import { Animal } from "@/models/animal";
import { AnimalsView } from "@/models/animals-view";
import type { NextPageContext } from "next";
import RootLayout from "./layout";

interface Props {
  view: AnimalsView;
}

export const GetServerSideProps = async (ctx: NextPageContext) => {
  const client = new AnimalClient();
  const view = await client.getAnimalsView();
  return { props: { view } };
};

export default function Home({ view }: Props) {
  console.log(view);

  return (
    <RootLayout>
      <main className="py-4 px-8">
        <h1 className="text-2xl">Animals</h1>

        <div>
          {view?.animals.map((animal: Animal) => (
            <h1>{animal.name}</h1>
          ))}
        </div>
      </main>
    </RootLayout>
  );
}
