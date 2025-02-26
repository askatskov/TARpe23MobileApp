using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. Mercury is classified as a terrestrial planet, with roughly the same surface gravity as Mars. The surface of Mercury is heavily cratered, as a result of countless impact events that have accumulated over billions of years.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Mercury_in_true_color.jpg/290px-Mercury_in_true_color.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Unmasking_the_Secrets_of_Mercury.jpg/220px-Unmasking_the_Secrets_of_Mercury.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is a terrestrial planet and is the closest in mass and size to its orbital neighbour Earth. Venus has by far the densest atmosphere of the terrestrial planets, composed mostly of carbon dioxide with a thick, global sulfuric acid cloud cover. At the surface it has a mean temperature of 737 K (464 °C; 867 °F) and a pressure 92 times that of Earth's at sea level.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b2/Venus_2_Approach_Image.jpg/290px-Venus_2_Approach_Image.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/PIA00084_Eistla_region_pancake_volcanoes.jpg/220px-PIA00084_Eistla_region_pancake_volcanoes.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/PIA00103_Venus_-_3-D_Perspective_View_of_Lavinia_Planitia.jpg/220px-PIA00103_Venus_-_3-D_Perspective_View_of_Lavinia_Planitia.jpg"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/The_Earth_seen_from_Apollo_17.jpg/290px-The_Earth_seen_from_Apollo_17.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2d/The_Mysterious_Case_of_the_Disappearing_Dust.jpg/290px-The_Mysterious_Case_of_the_Disappearing_Dust.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Archean.png/500px-Archean.png"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System, after Mercury. Its red color is due to iron oxide, or rust, on its surface. Mars has two moons, Phobos and Deimos, and is a target for future human exploration. The planet's past suggests that it may have had conditions suitable for life.",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png/290px-Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dc/PIA17944-MarsCuriosityRover-AfterCrossingDingoGapSanddune-20140209.jpg/220px-PIA17944-MarsCuriosityRover-AfterCrossingDingoGapSanddune-20140209.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c2/Olympus_Mons_-_ESA_Mars_Express_-_Flickr_-_Andrea_Luck.png/260px-Olympus_Mons_-_ESA_Mars_Express_-_Flickr_-_Andrea_Luck.png"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth and largest planet from the Sun, with a mass that is more than twice that of all the other planets in the Solar System combined. It is a gas giant with a massive atmosphere primarily composed of hydrogen and helium. Jupiter has 79 known moons and a famous storm known as the Great Red Spot.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Jupiter_and_its_shrunken_Great_Red_Spot.jpg/290px-Jupiter_and_its_shrunken_Great_Red_Spot.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b0/PIA21641-Jupiter-SouthernStorms-JunoCam-20170525.jpg/160px-PIA21641-Jupiter-SouthernStorms-JunoCam-20170525.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/PIA21775.jpg/220px-PIA21775.jpg"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and is best known for its extensive ring system, which is the most developed of any planet in the Solar System. Saturn is a gas giant and has at least 82 moons. It is the second-largest planet in the Solar System and has been explored by the Cassini spacecraft.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Saturn_during_Equinox.jpg/300px-Saturn_during_Equinox.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Saturn_Storm.jpg/220px-Saturn_Storm.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2e/Hubble_sees_a_flickering_light_display_on_Saturn.jpg/220px-Hubble_sees_a_flickering_light_display_on_Saturn.jpg"

                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun and is unique due to its extreme tilt, which makes it appear to roll on its side as it orbits the Sun. It is a gas giant with a cold atmosphere composed mainly of hydrogen, helium, and methane. Uranus has 27 known moons and was the first planet discovered with a telescope.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/6/69/Uranus_Voyager2_color_calibrated.png/290px-Uranus_Voyager2_color_calibrated.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4d/Adding_to_Uranus%27s_legacy.tif/lossy-page1-220px-Adding_to_Uranus%27s_legacy.tif.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Uranus_Dark_spot.jpg/220px-Uranus_Dark_spot.jpg"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest planet from the Sun in the Solar System. It is a gas giant with a deep blue color due to methane in its atmosphere. Neptune has 14 known moons, and its largest moon, Triton, is unique because it orbits in the opposite direction of the planet's rotation.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Neptune_Voyager2_color_calibrated.png/290px-Neptune_Voyager2_color_calibrated.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Neptune_Full.jpg/200px-Neptune_Full.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Neptune_storms.jpg/220px-Neptune_storms.jpg"
                }
            },
            new()
            {
                Name = "Pluto",
                Subtitle = "The former ninth planet",
                HeroImage = "pluto.png",
                Description = "Pluto is a dwarf planet in the Kuiper Belt. Once considered the ninth planet, it was reclassified in 2006. Pluto has a thin atmosphere and five known moons, with Charon being the largest.",
                AccentColorStart = Color.FromArgb("#3b1e08"),
                AccentColorEnd = Color.FromArgb("#c49a6c"),
                Images = new()
                {
					"https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Pluto_in_True_Color_-_High-Res.jpg/1200px-Pluto_in_True_Color_-_High-Res.jpg",
					"https://www.iau.org/static/archives/images/screen/iau0601a.jpg",
					"https://i.natgeofe.com/n/b103fff5-6a84-4d19-b65e-5856998816c3/PIA19952_2x3.jpg"
				}
            },
            new()
            {
                Name = "Eris",
                Subtitle = "The most massive dwarf planet",
                HeroImage = "eris.png",
                Description = "Eris is the most massive known dwarf planet in the Solar System. It is located in the scattered disc region and has one known moon, Dysnomia. Eris was a key reason for Pluto’s reclassification.",
                AccentColorStart = Color.FromArgb("#4c4c4c"),
                AccentColorEnd = Color.FromArgb("#a9a9a9"),
                Images = new()
                {
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSG6gj2_jvLR_vafhxvRxJMZvvR3EEo1a6Ufg&s",
					"https://solarsystem.nasa.gov/rails/active_storage/blobs/redirect/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBaUFSIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--1f24a5d7e143ef1d68416edb76a51ec065c1019c/eris_th.jpg?disposition=inline",
					"https://theplanets.org/123/2021/10/Eris-Facts.png"
				}
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "The fast-spinning dwarf planet",
                HeroImage = "haumea.png",
                Description = "Haumea is a dwarf planet located in the Kuiper Belt. It has a unique elongated shape due to its rapid rotation. Haumea has two known moons and a faint ring system.",
                AccentColorStart = Color.FromArgb("#5a3e3e"),
                AccentColorEnd = Color.FromArgb("#c2a385"),
                Images = new()
                {
					"https://science.nasa.gov/wp-content/uploads/2023/07/haumea-480x320-1-jpg.webp?w=320",
					"https://c02.purpledshub.com/uploads/sites/48/2024/01/dwarf-planet-haumea.jpg?w=1029&webp=1",
					"https://www.solarsystemscope.com/spacepedia/images/handbook/renders/haumea.png"
				}
            },
            new()
            {
                Name = "Makemake",
                Subtitle = "The reddish dwarf planet",
                HeroImage = "makemake.png",
                Description = "Makemake is a dwarf planet in the Kuiper Belt and the second-brightest object in that region after Pluto. It has a reddish hue and a single known moon named MK2.",
                AccentColorStart = Color.FromArgb("#6b2d0f"),
                AccentColorEnd = Color.FromArgb("#d6a06c"),
                Images = new()
                {
					"https://cdn.eso.org/images/screen/eso1246a.jpg",
					"https://science.nasa.gov/wp-content/uploads/2023/04/makemakemoon100mile-jpg.webp?w=2000",
					"https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8.jpg"
				}
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "The dwarf planet in the asteroid belt",
                HeroImage = "ceres.png",
                Description = "Ceres is the only dwarf planet located in the asteroid belt between Mars and Jupiter. It is the largest object in the belt and has bright spots believed to be salt deposits.",
                AccentColorStart = Color.FromArgb("#4e4e4e"),
                AccentColorEnd = Color.FromArgb("#a8a8a8"),
                Images = new()
                {
					"https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg/640px-Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
					"https://cdn.mos.cms.futurecdn.net/qnft8kRfeGWWLgaygo4fb9.jpg",
					"https://solarsystem.nasa.gov/rails/active_storage/blobs/redirect/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBdUZsIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--ca667488ed16597e35eaab71acd42034ca4f56c2/PIA20180-16-640x350.jpg"
				}
            },

        };
        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }
        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
