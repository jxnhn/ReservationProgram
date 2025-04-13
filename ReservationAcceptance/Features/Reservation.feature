Feature: Reserva de Sala
  Como administrador do sistema
  Eu quero gerenciar reservas de salas
  Para garantir alocações adequadas dos espaços

  @reserva @concorrencia
  Scenario: Tentar reservar uma sala já reservada
    Given existe uma sala com ID 1 e capacidade máxima de 5 pessoas
    When faço uma reserva para 4 pessoas na sala 1
    And tento fazer outra reserva para 3 pessoas na mesma sala 1
    Then a segunda reserva não deve ser criada
    

  @capacidade @limites
  Scenario: Tentar reservar sala com número de participantes acima da capacidade
    Given existe uma sala com ID 1 e capacidade máxima de 5 pessoas
    When tento fazer uma reserva inválida para 20 pessoas na sala 1
    Then a reserva não deve ser criada
 

  @validação @inexistente
  Scenario: Tentar reservar uma sala que não existe
    Given existe uma sala com ID 1 e capacidade máxima de 5 pessoas
    When tento fazer uma reserva para uma sala inexistente para 3 pessoas na sala 31
    Then a reserva não pode ser criada
  