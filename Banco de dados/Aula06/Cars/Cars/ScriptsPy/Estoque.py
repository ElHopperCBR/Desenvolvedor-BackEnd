from faker import Faker
from faker_vehicle import VehicleProvider


fake = Faker("pt_BR")
fake.add_provider(VehicleProvider)


def gerar_modelo(tipo_veiculo: str) -> str:
    if tipo_veiculo == "carro":
        return f"{fake.vehicle_model()} {fake.random_element(elements=('Sport', 'GT', 'Turbo', 'Elite', 'X', 'SE'))}"
    if tipo_veiculo == "moto":
        prefixo = fake.random_element(elements=('Street', 'Sport', 'Trail', 'Urban', 'Racing', 'Classic'))
        return f"{prefixo} {fake.vehicle_model()}"

    raise ValueError("Tipo de veículo inválido. Escolha 'carro' ou 'moto'.")


def main():
    print("Gerador de modelos falsos de veículos")
    print("Escolha: carro ou moto")

    while True:
        tipo = input("Digite o tipo de veículo: ").strip().lower()
        if tipo in {"carro", "moto"}:
            break
        print("Opção inválida. Digite 'carro' ou 'moto'.")

    while True:
        try:
            quantidade = int(input("Quantos modelos deseja gerar? "))
            if quantidade > 0:
                break
            print("Digite um número maior que zero.")
        except ValueError:
            print("Valor inválido. Digite apenas números inteiros.")

    print(f"\nModelos de {tipo} gerados:\n")
    for i in range(1, quantidade + 1):
        print(f"{gerar_modelo(tipo)}")


if __name__ == "__main__":
    main()
