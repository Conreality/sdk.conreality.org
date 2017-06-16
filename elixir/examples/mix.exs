# mix deps.get && iex -S mix

defmodule Examples.Mixfile do
  use Mix.Project

  def project do
    [app: :examples,
     version: "0.0.0",
     deps: [{:postgrex, "~> 0.13"}]]
  end
end
